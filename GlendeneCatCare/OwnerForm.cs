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
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddOwner.Left = 200;
            pnlAddOwner.Top = 0;
            pnlUpdateOwner.Left = 200;
            pnlUpdateOwner.Top = 0;
        }

        public void BindControls()
        {
            txtOwnerID.DataBindings.Add("Text", DM.dsGlendene, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.dsGlendene, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsGlendene, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsGlendene, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsGlendene, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsGlendene, "Owner.PhoneNumber");
            txtUpdateOwnerID.DataBindings.Add("Text", DM.dsGlendene, "Owner.OwnerID");
            txtUpdateLastName.DataBindings.Add("Text", DM.dsGlendene, "Owner.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.dsGlendene, "Owner.FirstName");
            txtUpdateStreetAddress.DataBindings.Add("Text", DM.dsGlendene, "Owner.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("Text", DM.dsGlendene, "Owner.Suburb");
            txtUpdatePhoneNumber.DataBindings.Add("Text", DM.dsGlendene, "Owner.PhoneNumber");
            txtOwnerID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtUpdateOwnerID.Enabled = false;
            lstOwner.DataSource = DM.dsGlendene;
            lstOwner.DisplayMember = "Owner.LastName";
            lstOwner.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            lstOwner.Visible = false;        // Note that if you usse this line of code
            lstOwner.Enabled = false;        // ... you do not need this line
            lstOwner.SelectedItem = null;    // ... or this line
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlAddOwner.Show();
        }

        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            txtOwnerID.Text = null;
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            if ((txtAddLastName.Text == ""))
            {
                MessageBox.Show("You must type in a last name", "Error");
            }
            else if ((txtAddFirstName.Text == ""))
            {
                MessageBox.Show("You must type in a first name", "Error");
            }
            else if ((txtAddStreetAddress.Text == ""))
            {
                MessageBox.Show("You must type in a street address", "Error");
            }
            else if ((txtAddSuburb.Text == ""))
            {
                MessageBox.Show("You must type in a suburb", "Error");
            }
            else if ((txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type in a phone number", "Error");
            }
            else
            {
                newOwnerRow["LastName"] = txtAddLastName.Text;
                newOwnerRow["FirstName"] = txtAddFirstName.Text;
                newOwnerRow["StreetAddress"] = txtAddStreetAddress.Text;
                newOwnerRow["Suburb"] = txtAddSuburb.Text;
                newOwnerRow["PhoneNumber"] = txtAddPhoneNumber.Text;
                DM.dtOwner.Rows.Add(newOwnerRow);
                MessageBox.Show("Owner added successfully", "Success");
                DM.UpdateOwner();
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            lstOwner.Enabled = true;
            lstOwner.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            btnDeleteOwner.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlUpdateOwner.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];

            if ((txtUpdateLastName.Text == ""))
            {
                MessageBox.Show("You must type in a last name", "Error");
            }
            else if ((txtUpdateFirstName.Text == ""))
            {
                MessageBox.Show("You must type in a first name", "Error");
            }
            else if ((txtUpdateStreetAddress.Text == ""))
            {
                MessageBox.Show("You must type in a street address", "Error");
            }
            else if ((txtUpdateSuburb.Text == ""))
            {
                MessageBox.Show("You must type in a suburb", "Error");
            }
            else if ((txtUpdatePhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type in a phone number", "Error");
            }
            else
            {
                updateOwnerRow["LastName"] = txtUpdateLastName.Text;
                updateOwnerRow["FirstName"] = txtUpdateFirstName.Text;
                updateOwnerRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateOwnerRow["Suburb"] = txtUpdateSuburb.Text;
                updateOwnerRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                MessageBox.Show("Owner updated successfully", "Success");
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateOwner.Hide();
            btnDeleteOwner.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] CatRow = DM.dtCat.Select("OwnerID = " + txtOwnerID.Text);
            if (CatRow.Length != 0)
            {
                MessageBox.Show("You may only delete Owners that do not have a cat", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner();
                    MessageBox.Show("Owner deleted successfully", "Success");
                }
            }
        }
    }
}
