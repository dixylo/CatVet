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
    public partial class MainForm : Form
    {
        private DataModule DM;                              // the reference to the form that holds the data components
        private CatForm frmCat;                             // the reference to the cat form
        private OwnerForm frmOwner;                         // the reference to the owner form
        private TreatmentForm frmTreatment;                 // the reference to the treatment form
        private VeterinarianForm frmVet;                    // the reference to the veterinarian form
        private VisitForm frmVisit;                         // the reference to the visit form
        private VisitTreatmentForm frmVisitTreatment;       // the reference to the treatment form
        private InvoiceForm frmInvoice;                     // the reference to the invoice form


        /// <summary>
        /// Constructor of the Main window
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the data module and loads the dataset when the Main window is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();              // Creates the data module and loads the dataset
        }

        /// <summary>
        /// Creates the Treatment Maintenance window when the Treatment Maintenance button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if (frmTreatment == null)           // Prevents more than one window is created
            {
                frmTreatment = new TreatmentForm(DM, this);
            }
            frmTreatment.ShowDialog();          // Shows the window
        }

        /// <summary>
        /// Creates the current window when the Exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Creates the Owner Maintenance window when the Owner Maintenance button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)           // Prevents more than one window is created
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();          // Shows the window
        }

        /// <summary>
        /// Creates the Veterinarian Maintenance window when the Veterinarian Maintenance button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVeterinarian_Click(object sender, EventArgs e)
        {
            if (frmVet == null)         // Prevents more than one window is created
            {
                frmVet = new VeterinarianForm(DM, this);
            }
            frmVet.ShowDialog();            // Shows the window
        }

        /// <summary>
        /// Creates the Cat Maintenance window when the Cat Maintenance button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCat_Click(object sender, EventArgs e)
        {
            if (frmCat == null)         // Prevents more than one window is created
            {
                frmCat = new CatForm(DM, this);
            }
            frmCat.ShowDialog();            // Shows the window
        }

        /// <summary>
        /// Creates the Visit Maintenance window when the Visit Maintenance button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (frmVisit == null)           // Prevents more than one window is created
            {
                frmVisit = new VisitForm();
            }
            frmVisit.ShowDialog();          // Shows the window
        }

        /// <summary>
        /// Creates the Allocate Treatment to Visit window when the Allocate Treatment to Visit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTreatmentVisit_Click(object sender, EventArgs e)
        {
            if (frmVisitTreatment == null)          // Prevents more than one window is created
            {
                frmVisitTreatment = new VisitTreatmentForm(DM, this);
            }
            frmVisitTreatment.ShowDialog();         // Shows the window
        }

        /// <summary>
        /// Creates the Invoice window when the Invoice button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)         // Prevents more than one window is created
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();            // Shows the window
        }
    }
}
