namespace PayrollManagementSystem.AdminUI
{
    partial class ModifyEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.listEmployee = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDateHired = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 53);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(85, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informations about Existing Employees.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(80, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.materialTextBox1);
            this.groupBox1.Controls.Add(this.listEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.groupBox1.Location = new System.Drawing.Point(19, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 468);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Employees";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Search Employee Name";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(28, 31);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(285, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // listEmployee
            // 
            this.listEmployee.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listEmployee.AutoSizeTable = false;
            this.listEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listEmployee.Depth = 0;
            this.listEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.listEmployee.FullRowSelect = true;
            this.listEmployee.GridLines = true;
            this.listEmployee.HideSelection = false;
            this.listEmployee.Location = new System.Drawing.Point(28, 87);
            this.listEmployee.MinimumSize = new System.Drawing.Size(200, 100);
            this.listEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.OwnerDraw = true;
            this.listEmployee.Size = new System.Drawing.Size(500, 324);
            this.listEmployee.TabIndex = 0;
            this.listEmployee.UseCompatibleStateImageBehavior = false;
            this.listEmployee.View = System.Windows.Forms.View.Details;
            this.listEmployee.Click += new System.EventHandler(this.listEmployee_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 320;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95373F));
            this.tableLayoutPanel1.Controls.Add(this.lblHourlyPay, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblSalary, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblJob, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblDateHired, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDOB, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblStreetNumber, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblContact, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMiddleName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(582, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 468);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHourlyPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHourlyPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblHourlyPay.Location = new System.Drawing.Point(150, 435);
            this.lblHourlyPay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(236, 30);
            this.lblHourlyPay.TabIndex = 25;
            this.lblHourlyPay.Text = "-";
            this.lblHourlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label27.Location = new System.Drawing.Point(3, 435);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(141, 30);
            this.label27.TabIndex = 24;
            this.label27.Text = "Hourly Pay:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblSalary.Location = new System.Drawing.Point(150, 399);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(236, 30);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "-";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label25.Location = new System.Drawing.Point(3, 399);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 30);
            this.label25.TabIndex = 22;
            this.label25.Text = "Monthly Salary:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJob.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblJob.Location = new System.Drawing.Point(150, 363);
            this.lblJob.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(236, 30);
            this.lblJob.TabIndex = 21;
            this.lblJob.Text = "-";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label23.Location = new System.Drawing.Point(3, 363);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 30);
            this.label23.TabIndex = 20;
            this.label23.Text = "Job Title:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // lblDateHired
            // 
            this.lblDateHired.AutoSize = true;
            this.lblDateHired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateHired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateHired.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblDateHired.Location = new System.Drawing.Point(150, 327);
            this.lblDateHired.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblDateHired.Name = "lblDateHired";
            this.lblDateHired.Size = new System.Drawing.Size(236, 30);
            this.lblDateHired.TabIndex = 19;
            this.lblDateHired.Text = "-";
            this.lblDateHired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label21.Location = new System.Drawing.Point(3, 327);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 30);
            this.label21.TabIndex = 18;
            this.label21.Text = "Date Hired:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblDOB.Location = new System.Drawing.Point(150, 291);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(236, 30);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "-";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label19.Location = new System.Drawing.Point(3, 291);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 30);
            this.label19.TabIndex = 16;
            this.label19.Text = "Date Of Birth:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblCity.Location = new System.Drawing.Point(150, 255);
            this.lblCity.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(236, 30);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "-";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label17.Location = new System.Drawing.Point(3, 255);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 30);
            this.label17.TabIndex = 14;
            this.label17.Text = "City:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStreetNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreetNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblStreetNumber.Location = new System.Drawing.Point(150, 219);
            this.lblStreetNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(236, 30);
            this.lblStreetNumber.TabIndex = 13;
            this.lblStreetNumber.Text = "-";
            this.lblStreetNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label15.Location = new System.Drawing.Point(3, 219);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 30);
            this.label15.TabIndex = 12;
            this.label15.Text = "Street No.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblContact.Location = new System.Drawing.Point(150, 183);
            this.lblContact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(236, 30);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "-";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label13.Location = new System.Drawing.Point(3, 183);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 30);
            this.label13.TabIndex = 10;
            this.label13.Text = "Contact #:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblEmail.Location = new System.Drawing.Point(150, 147);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(236, 30);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "-";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label11.Location = new System.Drawing.Point(3, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 30);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email Address:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblGender.Location = new System.Drawing.Point(150, 111);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(236, 30);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "-";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(3, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Gender:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblLastName.Location = new System.Drawing.Point(150, 75);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(236, 30);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "-";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMiddleName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblMiddleName.Location = new System.Drawing.Point(150, 39);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(236, 30);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "-";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Middle Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblFirstName.Location = new System.Drawing.Point(150, 3);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(236, 30);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "-";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeeImage
            // 
            this.employeeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeImage.Location = new System.Drawing.Point(985, 98);
            this.employeeImage.Name = "employeeImage";
            this.employeeImage.Size = new System.Drawing.Size(201, 201);
            this.employeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeImage.TabIndex = 12;
            this.employeeImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(985, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Archive Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnEditEmployee.Location = new System.Drawing.Point(985, 349);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(200, 41);
            this.btnEditEmployee.TabIndex = 14;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(25, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Click on the list to view employee details.";
            // 
            // ModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyEmployee";
            this.Size = new System.Drawing.Size(1257, 537);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListView listEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDateHired;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox employeeImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}
