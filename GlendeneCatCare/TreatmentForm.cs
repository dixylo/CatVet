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
    /// Creates a form for Treatment
    /// </summary>
    public partial class TreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        /// <summary>
        /// Constructor of the Treatment Form
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddTreatment.Left = 190;
            pnlAddTreatment.Top = 121;
        }

        /// <summary>
        /// Click event of the Next button, which moves down the highlight in the item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Load event of a Treatment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreatmentForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bind controls of several elements
        /// </summary>
        private void BindControls()
        {
            lblTreatmentID.DataBindings.Add("Text", DM.dsGlendene, "Treatment.TreatmentID");
            txtDescription.DataBindings.Add("Text", DM.dsGlendene, "Treatment.Description");
            txtCost.DataBindings.Add("Text", DM.dsGlendene, "Treatment.Cost");
            txtDescription.Enabled = false;
            txtCost.Enabled = false;
            lstTreatments.DataSource = DM.dsGlendene;
            lstTreatments.DisplayMember = "Treatment.Description";
            lstTreatments.ValueMember = "Treatment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "TREATMENT"];
        }

        /// <summary>
        /// Click event of the Previous button, which moves up the highlight in the item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// Click event of the Return button, which closes the Treatment window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds a new treatment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            /*lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");
            }
            else
            {
                newTreatmentRow["Description"] = txtDescription.Text;
                newTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                DM.dtTreatment.Rows.Add(newTreatmentRow);
                MessageBox.Show("Treatment added successfully", "Success");
                DM.UpdateTreatment();
            }*/

            lstTreatments.Visible = false;          // Note that if you use this line of code
            lstTreatments.Enabled = false;          // ... you do not need this line
            lstTreatments.SelectedItem = null;      //... or this line
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateTreatment.Enabled = false;
            btnAddTreatment.Enabled = false;
            pnlAddTreatment.Show();
        }

        /// <summary>
        /// Deletes an highlighted entry from the treatment list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            DataRow deleteTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.dtVisitTreatment.Select("TreatmentID = " + lblTreatmentID.Text);
            if (VisitTreatmentRow.Length != 0)
            {
                MessageBox.Show("You may only delete Treatments that are not allocated to visit", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTreatmentRow.Delete();
                    DM.UpdateTreatment();
                }
            }
        }

        /// <summary>
        /// Modifies an highlighted entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];

            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");
            }
            else
            {
                updateTreatmentRow["Description"] = txtDescription.Text;
                updateTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                currencyManager.EndCurrentEdit();
                DM.UpdateTreatment();
                MessageBox.Show("Treatment updated successfully", "Success");
            }
        }

        /// <summary>
        /// TextChanged event of the Description text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cancels the adding of a new treatment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTreatment.Hide();
            lstTreatments.Enabled = true;
            lstTreatments.Visible = true;
            btnDeleteTreatment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateTreatment.Enabled = true;
            btnAddTreatment.Enabled = true;
        }

        /// <summary>
        /// Saves the new treatment the details of which are filled in the text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");
            }
            else
            {
                try
                {
                    newTreatmentRow["Description"] = txtAddDescription.Text;
                    newTreatmentRow["Cost"] = Convert.ToDouble(txtAddCost.Text);
                    DM.dtTreatment.Rows.Add(newTreatmentRow);
                    MessageBox.Show("Treatment added successfully", "Success");
                    DM.UpdateTreatment();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for cost", "Error");
                }
            }
        }
    }
}
