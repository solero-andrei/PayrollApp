namespace PayrollManagementSystem.AdminUI
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.basicInformation = new System.Windows.Forms.GroupBox();
            this.txtCity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtStreet = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerateID = new MaterialSkin.Controls.MaterialButton();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMiddleName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblParaHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.contactInformation = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbJobPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.btnUpload = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.employeeImage = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkAccountGenerator = new System.Windows.Forms.LinkLabel();
            this.basicInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contactInformation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // basicInformation
            // 
            this.basicInformation.Controls.Add(this.txtCity);
            this.basicInformation.Controls.Add(this.txtStreet);
            this.basicInformation.Controls.Add(this.materialDivider1);
            this.basicInformation.Controls.Add(this.label1);
            this.basicInformation.Controls.Add(this.dateOfBirth);
            this.basicInformation.Controls.Add(this.radFemale);
            this.basicInformation.Controls.Add(this.radMale);
            this.basicInformation.Controls.Add(this.btnGenerateID);
            this.basicInformation.Controls.Add(this.txtLastName);
            this.basicInformation.Controls.Add(this.txtMiddleName);
            this.basicInformation.Controls.Add(this.txtFirstName);
            this.basicInformation.Controls.Add(this.txtID);
            this.basicInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicInformation.Location = new System.Drawing.Point(25, 61);
            this.basicInformation.Name = "basicInformation";
            this.basicInformation.Size = new System.Drawing.Size(417, 467);
            this.basicInformation.TabIndex = 1;
            this.basicInformation.TabStop = false;
            this.basicInformation.Text = "Basic Information";
            // 
            // txtCity
            // 
            this.txtCity.AnimateReadOnly = false;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Depth = 0;
            this.txtCity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCity.Hint = "City";
            this.txtCity.LeadingIcon = null;
            this.txtCity.Location = new System.Drawing.Point(23, 399);
            this.txtCity.MaxLength = 50;
            this.txtCity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(377, 50);
            this.txtCity.TabIndex = 13;
            this.txtCity.Text = "";
            this.txtCity.TrailingIcon = null;
            // 
            // txtStreet
            // 
            this.txtStreet.AnimateReadOnly = false;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Depth = 0;
            this.txtStreet.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStreet.Hint = "Street Number";
            this.txtStreet.LeadingIcon = null;
            this.txtStreet.Location = new System.Drawing.Point(23, 343);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStreet.Multiline = false;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(377, 50);
            this.txtStreet.TabIndex = 12;
            this.txtStreet.Text = "";
            this.txtStreet.TrailingIcon = null;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(14, 332);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(388, 1);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(184, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Birthdate:";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth.Location = new System.Drawing.Point(278, 256);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(122, 30);
            this.dateOfBirth.TabIndex = 6;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Depth = 0;
            this.radFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.radFemale.Location = new System.Drawing.Point(19, 290);
            this.radFemale.Margin = new System.Windows.Forms.Padding(0);
            this.radFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radFemale.Name = "radFemale";
            this.radFemale.Ripple = true;
            this.radFemale.Size = new System.Drawing.Size(87, 37);
            this.radFemale.TabIndex = 5;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Depth = 0;
            this.radMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.radMale.Location = new System.Drawing.Point(19, 253);
            this.radMale.Margin = new System.Windows.Forms.Padding(0);
            this.radMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMale.Name = "radMale";
            this.radMale.Ripple = true;
            this.radMale.Size = new System.Drawing.Size(70, 37);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.AutoSize = false;
            this.btnGenerateID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateID.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateID.Depth = 0;
            this.btnGenerateID.HighEmphasis = true;
            this.btnGenerateID.Icon = null;
            this.btnGenerateID.Location = new System.Drawing.Point(259, 38);
            this.btnGenerateID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateID.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateID.Size = new System.Drawing.Size(127, 35);
            this.btnGenerateID.TabIndex = 1;
            this.btnGenerateID.Text = "Generate";
            this.btnGenerateID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateID.UseAccentColor = false;
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(19, 200);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(377, 50);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.AnimateReadOnly = false;
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Depth = 0;
            this.txtMiddleName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMiddleName.Hint = "Middle Name";
            this.txtMiddleName.LeadingIcon = null;
            this.txtMiddleName.Location = new System.Drawing.Point(19, 144);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMiddleName.Multiline = false;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(377, 50);
            this.txtMiddleName.TabIndex = 2;
            this.txtMiddleName.Text = "";
            this.txtMiddleName.TrailingIcon = null;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Hint = "First Name";
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(19, 88);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(377, 50);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Hint = "Employee ID";
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(19, 32);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(233, 50);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lblParaHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 53);
            this.panel1.TabIndex = 2;
            // 
            // lblParaHeader
            // 
            this.lblParaHeader.AutoSize = true;
            this.lblParaHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblParaHeader.Location = new System.Drawing.Point(85, 33);
            this.lblParaHeader.Name = "lblParaHeader";
            this.lblParaHeader.Size = new System.Drawing.Size(257, 16);
            this.lblParaHeader.TabIndex = 2;
            this.lblParaHeader.Text = "Fill up required fields to add new employee.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblHeader.Location = new System.Drawing.Point(80, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(236, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add New Employee";
            // 
            // contactInformation
            // 
            this.contactInformation.Controls.Add(this.txtContactNumber);
            this.contactInformation.Controls.Add(this.txtEmail);
            this.contactInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.contactInformation.Location = new System.Drawing.Point(448, 61);
            this.contactInformation.Name = "contactInformation";
            this.contactInformation.Size = new System.Drawing.Size(417, 175);
            this.contactInformation.TabIndex = 4;
            this.contactInformation.TabStop = false;
            this.contactInformation.Text = "Contact Information";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.AnimateReadOnly = false;
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContactNumber.Hint = "Contact Number";
            this.txtContactNumber.LeadingIcon = null;
            this.txtContactNumber.Location = new System.Drawing.Point(20, 88);
            this.txtContactNumber.MaxLength = 50;
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContactNumber.Multiline = false;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(377, 50);
            this.txtContactNumber.TabIndex = 9;
            this.txtContactNumber.Text = "";
            this.txtContactNumber.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email Address";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(20, 32);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(377, 50);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.cmbJobPosition);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.groupBox3.Location = new System.Drawing.Point(448, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 286);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Job Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(23, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Taxes and Deductions are computed at payroll";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHourlyPay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHireDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMonthlySalary, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJobID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 166);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(3, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 43);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hourly Pay:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHourlyPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHourlyPay.Location = new System.Drawing.Point(191, 123);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(183, 43);
            this.lblHourlyPay.TabIndex = 10;
            this.lblHourlyPay.Text = "-";
            this.lblHourlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(3, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 41);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hire Date:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHireDate.Location = new System.Drawing.Point(191, 82);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(183, 41);
            this.lblHireDate.TabIndex = 8;
            this.lblHireDate.Text = "-";
            this.lblHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMonthlySalary.Location = new System.Drawing.Point(191, 41);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(183, 41);
            this.lblMonthlySalary.TabIndex = 7;
            this.lblMonthlySalary.Text = "-";
            this.lblMonthlySalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJobID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.Location = new System.Drawing.Point(191, 0);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(183, 41);
            this.lblJobID.TabIndex = 1;
            this.lblJobID.Text = "-";
            this.lblJobID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monthly Salary:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJobPosition
            // 
            this.cmbJobPosition.AutoResize = false;
            this.cmbJobPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbJobPosition.Depth = 0;
            this.cmbJobPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbJobPosition.DropDownHeight = 174;
            this.cmbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobPosition.DropDownWidth = 121;
            this.cmbJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbJobPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbJobPosition.FormattingEnabled = true;
            this.cmbJobPosition.Hint = "Job Position";
            this.cmbJobPosition.IntegralHeight = false;
            this.cmbJobPosition.ItemHeight = 43;
            this.cmbJobPosition.Location = new System.Drawing.Point(20, 21);
            this.cmbJobPosition.MaxDropDownItems = 4;
            this.cmbJobPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbJobPosition.Name = "cmbJobPosition";
            this.cmbJobPosition.Size = new System.Drawing.Size(377, 49);
            this.cmbJobPosition.StartIndex = 0;
            this.cmbJobPosition.TabIndex = 10;
            this.cmbJobPosition.SelectedIndexChanged += new System.EventHandler(this.cmbJobPosition_SelectedIndexChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpload.Depth = 0;
            this.btnUpload.HighEmphasis = true;
            this.btnUpload.Icon = null;
            this.btnUpload.Location = new System.Drawing.Point(971, 276);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpload.Size = new System.Drawing.Size(127, 36);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpload.UseAccentColor = false;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(873, 477);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(158, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Employee";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(1038, 477);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(158, 47);
            this.materialButton4.TabIndex = 13;
            this.materialButton4.Text = "Cancel";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label14.Location = new System.Drawing.Point(902, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 41);
            this.label14.TabIndex = 14;
            this.label14.Text = "Auto Generated Account for Employee Dashboard Account";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.lblUserName.Location = new System.Drawing.Point(926, 361);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(216, 41);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeImage
            // 
            this.employeeImage.Location = new System.Drawing.Point(934, 61);
            this.employeeImage.Name = "employeeImage";
            this.employeeImage.Size = new System.Drawing.Size(200, 200);
            this.employeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeImage.TabIndex = 3;
            this.employeeImage.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.lblPassword.Location = new System.Drawing.Point(926, 401);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(216, 41);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkAccountGenerator
            // 
            this.linkAccountGenerator.AutoSize = true;
            this.linkAccountGenerator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAccountGenerator.Location = new System.Drawing.Point(871, 455);
            this.linkAccountGenerator.Name = "linkAccountGenerator";
            this.linkAccountGenerator.Size = new System.Drawing.Size(123, 16);
            this.linkAccountGenerator.TabIndex = 17;
            this.linkAccountGenerator.TabStop = true;
            this.linkAccountGenerator.Text = "Generate Username";
            this.linkAccountGenerator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAccountGenerator_LinkClicked);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkAccountGenerator);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.contactInformation);
            this.Controls.Add(this.employeeImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.basicInformation);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1257, 537);
            this.basicInformation.ResumeLayout(false);
            this.basicInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contactInformation.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox basicInformation;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton radFemale;
        private MaterialSkin.Controls.MaterialRadioButton radMale;
        private MaterialSkin.Controls.MaterialButton btnGenerateID;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtMiddleName;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label lblParaHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox employeeImage;
        private System.Windows.Forms.GroupBox contactInformation;
        private MaterialSkin.Controls.MaterialTextBox txtContactNumber;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbJobPosition;
        private MaterialSkin.Controls.MaterialButton btnUpload;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkAccountGenerator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHireDate;
        private MaterialSkin.Controls.MaterialTextBox txtCity;
        private MaterialSkin.Controls.MaterialTextBox txtStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHourlyPay;
    }
}
