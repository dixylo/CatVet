namespace GlendeneCatCare
{
    partial class CatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCats = new System.Windows.Forms.ListBox();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateofBirth = new System.Windows.Forms.TextBox();
            this.txtNeutered = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddCat = new System.Windows.Forms.Panel();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboAddOwnerName = new System.Windows.Forms.ComboBox();
            this.cboAddOwnerID = new System.Windows.Forms.ComboBox();
            this.cbxAddNeutered = new System.Windows.Forms.CheckBox();
            this.dtpAddDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cboAddGender = new System.Windows.Forms.ComboBox();
            this.txtAddBreed = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddOwnerID = new System.Windows.Forms.Label();
            this.lblAddNeutered = new System.Windows.Forms.Label();
            this.lblAddDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.lblAddBreed = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.pnlAddCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.Location = new System.Drawing.Point(12, 12);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(181, 251);
            this.lstCats.TabIndex = 0;
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(242, 15);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(40, 13);
            this.lblCatID.TabIndex = 1;
            this.lblCatID.Text = "Cat ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(244, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(244, 75);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(38, 13);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(237, 105);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(213, 135);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(228, 165);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(54, 13);
            this.lblNeutered.TabIndex = 6;
            this.lblNeutered.Text = "Neutered:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(227, 195);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(55, 13);
            this.lblOwnerID.TabIndex = 7;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(288, 12);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(86, 20);
            this.txtCatID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(86, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(288, 72);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(86, 20);
            this.txtBreed.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(288, 102);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(86, 20);
            this.txtGender.TabIndex = 11;
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Location = new System.Drawing.Point(288, 132);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(86, 20);
            this.txtDateofBirth.TabIndex = 12;
            // 
            // txtNeutered
            // 
            this.txtNeutered.Location = new System.Drawing.Point(288, 162);
            this.txtNeutered.Name = "txtNeutered";
            this.txtNeutered.Size = new System.Drawing.Size(86, 20);
            this.txtNeutered.TabIndex = 13;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(288, 192);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(86, 20);
            this.txtOwnerID.TabIndex = 14;
            this.txtOwnerID.TextChanged += new System.EventHandler(this.txtOwnerID_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 291);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(86, 27);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(107, 291);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 27);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(199, 291);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(86, 27);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(291, 291);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(86, 27);
            this.btnUpdateCat.TabIndex = 18;
            this.btnUpdateCat.Text = "Update Cat";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(383, 291);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(86, 27);
            this.btnDeleteCat.TabIndex = 19;
            this.btnDeleteCat.Text = "Delete Cat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(475, 291);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 27);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddCat
            // 
            this.pnlAddCat.Controls.Add(this.btnSaveCat);
            this.pnlAddCat.Controls.Add(this.btnCancel);
            this.pnlAddCat.Controls.Add(this.cboAddOwnerName);
            this.pnlAddCat.Controls.Add(this.cboAddOwnerID);
            this.pnlAddCat.Controls.Add(this.cbxAddNeutered);
            this.pnlAddCat.Controls.Add(this.dtpAddDateOfBirth);
            this.pnlAddCat.Controls.Add(this.cboAddGender);
            this.pnlAddCat.Controls.Add(this.txtAddBreed);
            this.pnlAddCat.Controls.Add(this.txtAddName);
            this.pnlAddCat.Controls.Add(this.lblAddOwnerID);
            this.pnlAddCat.Controls.Add(this.lblAddNeutered);
            this.pnlAddCat.Controls.Add(this.lblAddDateOfBirth);
            this.pnlAddCat.Controls.Add(this.lblAddGender);
            this.pnlAddCat.Controls.Add(this.lblAddBreed);
            this.pnlAddCat.Controls.Add(this.lblAddName);
            this.pnlAddCat.Location = new System.Drawing.Point(383, 0);
            this.pnlAddCat.Name = "pnlAddCat";
            this.pnlAddCat.Size = new System.Drawing.Size(275, 236);
            this.pnlAddCat.TabIndex = 21;
            this.pnlAddCat.Visible = false;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(175, 198);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(86, 27);
            this.btnSaveCat.TabIndex = 22;
            this.btnSaveCat.Text = "Save Cat";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 27);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboAddOwnerName
            // 
            this.cboAddOwnerName.FormattingEnabled = true;
            this.cboAddOwnerName.Location = new System.Drawing.Point(154, 162);
            this.cboAddOwnerName.Name = "cboAddOwnerName";
            this.cboAddOwnerName.Size = new System.Drawing.Size(107, 21);
            this.cboAddOwnerName.TabIndex = 15;
            // 
            // cboAddOwnerID
            // 
            this.cboAddOwnerID.FormattingEnabled = true;
            this.cboAddOwnerID.Location = new System.Drawing.Point(84, 162);
            this.cboAddOwnerID.Name = "cboAddOwnerID";
            this.cboAddOwnerID.Size = new System.Drawing.Size(64, 21);
            this.cboAddOwnerID.TabIndex = 14;
            // 
            // cbxAddNeutered
            // 
            this.cbxAddNeutered.AutoSize = true;
            this.cbxAddNeutered.Location = new System.Drawing.Point(84, 132);
            this.cbxAddNeutered.Name = "cbxAddNeutered";
            this.cbxAddNeutered.Size = new System.Drawing.Size(15, 14);
            this.cbxAddNeutered.TabIndex = 13;
            this.cbxAddNeutered.UseVisualStyleBackColor = true;
            // 
            // dtpAddDateOfBirth
            // 
            this.dtpAddDateOfBirth.Location = new System.Drawing.Point(84, 102);
            this.dtpAddDateOfBirth.Name = "dtpAddDateOfBirth";
            this.dtpAddDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpAddDateOfBirth.TabIndex = 12;
            // 
            // cboAddGender
            // 
            this.cboAddGender.FormattingEnabled = true;
            this.cboAddGender.Location = new System.Drawing.Point(84, 72);
            this.cboAddGender.Name = "cboAddGender";
            this.cboAddGender.Size = new System.Drawing.Size(51, 21);
            this.cboAddGender.TabIndex = 11;
            this.cboAddGender.Text = "Male";
            // 
            // txtAddBreed
            // 
            this.txtAddBreed.Location = new System.Drawing.Point(84, 42);
            this.txtAddBreed.Name = "txtAddBreed";
            this.txtAddBreed.Size = new System.Drawing.Size(86, 20);
            this.txtAddBreed.TabIndex = 10;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(84, 12);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(86, 20);
            this.txtAddName.TabIndex = 9;
            // 
            // lblAddOwnerID
            // 
            this.lblAddOwnerID.AutoSize = true;
            this.lblAddOwnerID.Location = new System.Drawing.Point(23, 165);
            this.lblAddOwnerID.Name = "lblAddOwnerID";
            this.lblAddOwnerID.Size = new System.Drawing.Size(55, 13);
            this.lblAddOwnerID.TabIndex = 8;
            this.lblAddOwnerID.Text = "Owner ID:";
            // 
            // lblAddNeutered
            // 
            this.lblAddNeutered.AutoSize = true;
            this.lblAddNeutered.Location = new System.Drawing.Point(24, 132);
            this.lblAddNeutered.Name = "lblAddNeutered";
            this.lblAddNeutered.Size = new System.Drawing.Size(54, 13);
            this.lblAddNeutered.TabIndex = 7;
            this.lblAddNeutered.Text = "Neutered:";
            // 
            // lblAddDateOfBirth
            // 
            this.lblAddDateOfBirth.AutoSize = true;
            this.lblAddDateOfBirth.Location = new System.Drawing.Point(9, 102);
            this.lblAddDateOfBirth.Name = "lblAddDateOfBirth";
            this.lblAddDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblAddDateOfBirth.TabIndex = 6;
            this.lblAddDateOfBirth.Text = "Date of Birth:";
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Location = new System.Drawing.Point(33, 75);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(45, 13);
            this.lblAddGender.TabIndex = 5;
            this.lblAddGender.Text = "Gender:";
            // 
            // lblAddBreed
            // 
            this.lblAddBreed.AutoSize = true;
            this.lblAddBreed.Location = new System.Drawing.Point(40, 45);
            this.lblAddBreed.Name = "lblAddBreed";
            this.lblAddBreed.Size = new System.Drawing.Size(38, 13);
            this.lblAddBreed.TabIndex = 4;
            this.lblAddBreed.Text = "Breed:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(40, 15);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(38, 13);
            this.lblAddName.TabIndex = 3;
            this.lblAddName.Text = "Name:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(390, 195);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerName.TabIndex = 22;
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 329);
            this.Controls.Add(this.pnlAddCat);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtNeutered);
            this.Controls.Add(this.txtDateofBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblNeutered);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lstCats);
            this.Controls.Add(this.lblOwnerName);
            this.Name = "CatForm";
            this.Text = "Cat Maintenance";
            this.pnlAddCat.ResumeLayout(false);
            this.pnlAddCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateofBirth;
        private System.Windows.Forms.TextBox txtNeutered;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddCat;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboAddOwnerName;
        private System.Windows.Forms.ComboBox cboAddOwnerID;
        private System.Windows.Forms.CheckBox cbxAddNeutered;
        private System.Windows.Forms.DateTimePicker dtpAddDateOfBirth;
        private System.Windows.Forms.ComboBox cboAddGender;
        private System.Windows.Forms.TextBox txtAddBreed;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddOwnerID;
        private System.Windows.Forms.Label lblAddNeutered;
        private System.Windows.Forms.Label lblAddDateOfBirth;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddBreed;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblOwnerName;
    }
}