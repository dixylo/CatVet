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
    /// Interacts with the user on the information of veterinarians
    /// </summary>
    public partial class VeterinarianForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public VeterinarianForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// Bind controls of several elements
        /// </summary>
        public void BindControls()
        {
            lblVeterinarianID.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.VeterinarianID");
            txtLastName.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.FirstName");
            txtRate.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.Rate");
            lstVeterinarians.DataSource = DM.dsGlendene;
            lstVeterinarians.DisplayMember = "Veterinarian.LastName";
            lstVeterinarians.ValueMember = "Veterinarian.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "VETERINARIAN"];
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
        /// Click event of the Return button, which closes the Treatment window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Click event of the Add Veterinarian button, which adds an entry, 
        /// described by the Last Name, First Name and Rate text fields, to the veterinarian list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddVeterinarian_Click(object sender, EventArgs e)
        {
            // Create a new row that the variables will be added into
            DataRow newVeterinarianRow = DM.dtVeterinarian.NewRow();

            // If any of the text areas are empty then do not write data and return
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newVeterinarianRow["LastName"] = txtLastName.Text;
                newVeterinarianRow["FirstName"] = txtFirstName.Text;
                newVeterinarianRow["Rate"] = Convert.ToDouble(txtRate.Text);
                // Add the new row to the Table
                DM.dtVeterinarian.Rows.Add(newVeterinarianRow);
                DM.UpdateVeterinarian();
                // Give the user a success message
                MessageBox.Show("Veterinarian added successfully", "Success");
            }
        }

        /// <summary>
        /// Click event of the Delete Veterinarian button, which deletes an highlighted entry from the veterinarian list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow deleteVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            DataRow[] VisitRow = DM.dtVisit.Select("VeterinarianID = " + lblVeterinarianID.Text);
            if (VisitRow.Length != 0)
            {
                MessageBox.Show("You may only delete Veterinarians who do not have visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVeterinarianRow.Delete();
                    DM.UpdateVeterinarian();
                }
            }
        }

        /// <summary>
        /// Click event of the Update Veterinarian button, which modifies an highlighted entry, 
        /// using the Last Name, First Name and Rate text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow updateVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];

            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                //Add the text areas
                updateVeterinarianRow["LastName"] = txtLastName.Text;
                updateVeterinarianRow["FirstName"] = txtFirstName.Text;
                updateVeterinarianRow["Rate"] = Convert.ToDouble(txtRate.Text);
                // Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateVeterinarian();
                // Give the user a success message
                MessageBox.Show("Veterinarian updated successfully", "Success");
            }
        }
    }
}
