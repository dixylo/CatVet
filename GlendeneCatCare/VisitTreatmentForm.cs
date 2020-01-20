using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlendeneCatCare
{
    /// <summary>
    /// Shows the information of the treatments of visits
    /// </summary>
    public partial class VisitTreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmTreatment;
        private CurrencyManager cmVisit;
        private CurrencyManager cmVisitTreatment;
        private CurrencyManager cmVVT;
        //private DataTable dt = new DataTable();
        //private CurrencyManager cmDt;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public VisitTreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmTreatment = (CurrencyManager)this.BindingContext[DM.dsGlendene, "Treatment"];
            cmVisit = (CurrencyManager)this.BindingContext[DM.dsGlendene, "Visit"];
            cmVisitTreatment = (CurrencyManager)this.BindingContext[DM.dsGlendene, "VisitTreatment"];
            //cmDt = (CurrencyManager)this.BindingContext[dt];
            cmVVT = (CurrencyManager)this.BindingContext[DM.dsGlendene, "Visit.Visit_VisitTreatment"];
            BindControls();
        }

        /// <summary>
        /// Bind controls of data
        /// </summary>
        public void BindControls()
        {
            dgvVisits.DataSource = DM.dsGlendene;
            dgvVisits.DataMember = "Visit";

            dgvTreatments.DataSource = DM.dsGlendene;
            dgvTreatments.DataMember = "Treatment";

            dgvVisitTreatments.DataSource = DM.dsGlendene;
            dgvVisitTreatments.DataMember = "Visit.Visit_VisitTreatment";
        }

        /// <summary>
        /// Closes the current window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Allocates treatments to visits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtVisit.Rows[cmVisit.Position]["Status"].ToString() == "Pending")
                {
                    DataRow newVisitTreatment = DM.dtVisitTreatment.NewRow();

                    newVisitTreatment["TreatmentID"] = dgvTreatments["TreatmentID", cmTreatment.Position].Value;
                    newVisitTreatment["VisitID"] = dgvVisits["VisitID", cmVisit.Position].Value;
                    newVisitTreatment["Quantity"] = Convert.ToInt32(txtQuantity.Text);

                    DM.dsGlendene.Tables["VisitTreatment"].Rows.Add(newVisitTreatment);     //add a new row to dataset 
                    DM.UpdateVisitTreatment();      //update database
                }
                else
                {
                    MessageBox.Show("Cannot allocate treatments to paid visits.", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This treatment has already been allocated to this visit.", "Error");
            }
        }

        /// <summary>
        /// Removes treatments of visits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DM.dtVisit.Rows[cmVisit.Position]["Status"].ToString() == "Pending")
            {
                string VisitID = DM.dtVisit.Rows[cmVisit.Position]["VisitID"].ToString();
                string TreatmentID = dgvVisitTreatments.Rows[cmVVT.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtVisitTreatment.Rows.Count; i++)
                {
                    string sID = DM.dtVisitTreatment.Rows[i]["VisitID"].ToString();
                    string aID = DM.dtVisitTreatment.Rows[i]["TreatmentID"].ToString();

                    if (VisitID == sID && TreatmentID == aID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.dsGlendene.Tables["VisitTreatment"].Rows[row];
                dr.Delete();
                DM.UpdateVisitTreatment();      //update database
            }
            else
            {
                MessageBox.Show("You may only remove treatments from pending Visits.", "Error");
            }
        }

        
    }
}
