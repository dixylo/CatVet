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
    public partial class CatForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmOwner;

        /// <summary>
        /// Constructor of CatForm
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>
        public CatForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddCat.Left = 200;
            pnlAddCat.Top = 0;
        }

        /// <summary>
        /// BindControls of a set of components
        /// </summary>
        public void BindControls()
        {
            txtCatID.DataBindings.Add("Text", DM.dsGlendene, "Cat.CatID");
            txtName.DataBindings.Add("Text", DM.dsGlendene, "Cat.Name");
            txtBreed.DataBindings.Add("Text", DM.dsGlendene, "Cat.Breed");
            txtGender.DataBindings.Add("Text", DM.dsGlendene, "Cat.Gender");
            txtDateofBirth.DataBindings.Add("Text", DM.dsGlendene, "Cat.DateOfBirth");
            txtNeutered.DataBindings.Add("Text", DM.dsGlendene, "Cat.Neutered");
            txtOwnerID.DataBindings.Add("Text", DM.dsGlendene, "Cat.OwnerID");
            txtCatID.Enabled = false;
            txtName.Enabled = false;
            txtBreed.Enabled = false;
            txtGender.Enabled = false;
            txtDateofBirth.Enabled = false;
            txtNeutered.Enabled = false;
            txtOwnerID.Enabled = false;
            lstCats.DataSource = DM.dsGlendene;
            lstCats.DisplayMember = "Cat.Name";
            lstCats.ValueMember = "Cat.Name";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
        }

        /// <summary>
        /// Cancels the adding of a new cat record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddCat.Hide();
            lstCats.Enabled = true;
            lstCats.Visible = true;
            btnDeleteCat.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateCat.Enabled = true;
            btnAddCat.Enabled = true;
        }

        /// <summary>
        /// Loads the owner's information
        /// </summary>
        private void LoadOwners()
        {
            cboAddOwnerName.DataSource = DM.dsGlendene;
            cboAddOwnerName.DisplayMember = "Owner.LastName";
            cboAddOwnerName.ValueMember = "Owner.LastName";
            cboAddOwnerID.DataSource = DM.dsGlendene;
            cboAddOwnerID.DisplayMember = "Owner.OwnerID";
            cboAddOwnerID.ValueMember = "Owner.OwnerID";
            cboAddGender.Items.Add("Male");
            cboAddGender.Items.Add("Female");
        }

        /// <summary>
        /// Adds a new cat record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            lstCats.Visible = false;        // Note that if you usse this line of code
            lstCats.Enabled = false;        // ... you do not need this line
            lstCats.SelectedItem = null;    // ... or this line
            btnDeleteCat.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateCat.Enabled = false;
            btnAddCat.Enabled = false;
            pnlAddCat.Show();
            LoadOwners();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            lblCatID.Text = null;
            DataRow newCatRow = DM.dtCat.NewRow();

            if ((txtAddName.Text == ""))
            {
                MessageBox.Show("You must type in a Cat name", "Error");
            }
            else
            {
                try
                {
                    newCatRow["Name"] = txtAddName.Text;
                    newCatRow["Breed"] = txtAddBreed.Text;
                    newCatRow["Gender"] = cboAddGender.Text;
                    newCatRow["DateOfBirth"] = dtpAddDateOfBirth.Text;
                    newCatRow["Neutered"] = cbxAddNeutered.Checked;
                    newCatRow["OwnerID"] = cboAddOwnerID.Text;
                    DM.dtCat.Rows.Add(newCatRow);
                    MessageBox.Show("Cat added successfully", "Success");
                    DM.UpdateCat();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for cost", "Error");
                }
            }
        }

        private void txtOwnerID_TextChanged(object sender, EventArgs e)
        {
            if (txtOwnerID.Text == "")
            {
                lblOwnerName.Text = "";
            }
            else
            {
                int anOwnerID = Convert.ToInt32(txtOwnerID.Text);
                cmOwner.Position = DM.ownerView.Find(anOwnerID);
                DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
                lblOwnerName.Text = drOwner["LastName"].ToString();
            }
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


    }
}
