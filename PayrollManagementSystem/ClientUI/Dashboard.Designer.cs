namespace PayrollManagementSystem.ClientUI
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.timeDate = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHistoryLate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHistoryDate = new System.Windows.Forms.Label();
            this.lblHistoryPay = new System.Windows.Forms.Label();
            this.lblHistoryWorkHours = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHistoryTimeOut = new System.Windows.Forms.Label();
            this.lblHistoryAttendance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblHistoryTimeIn = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAttendanceID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMinutesLate = new System.Windows.Forms.Label();
            this.lblEstimatedPay = new System.Windows.Forms.Label();
            this.lblHoursOfWork = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimein = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtGreeting = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeDate
            // 
            this.timeDate.Tick += new System.EventHandler(this.timeDate_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 72);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(974, 625);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 555);
            this.panel2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(16, 414);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 16);
            this.label20.TabIndex = 17;
            this.label20.Text = "Required Time In: &8:30 AM";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserID.Location = new System.Drawing.Point(103, 438);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(15, 16);
            this.lblUserID.TabIndex = 16;
            this.lblUserID.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(16, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Employee ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.materialDivider2);
            this.groupBox2.Controls.Add(this.calendar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(430, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 530);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendance Logs";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.44318F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.55682F));
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblOvertime, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryLate, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryDate, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryPay, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryWorkHours, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryTimeOut, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryAttendance, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHistoryTimeIn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 232);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 292);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Arial", 12F);
            this.label16.Location = new System.Drawing.Point(6, 222);
            this.label16.Margin = new System.Windows.Forms.Padding(6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Minutes Late:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryLate
            // 
            this.lblHistoryLate.AutoSize = true;
            this.lblHistoryLate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryLate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryLate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryLate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryLate.Location = new System.Drawing.Point(169, 218);
            this.lblHistoryLate.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryLate.Name = "lblHistoryLate";
            this.lblHistoryLate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryLate.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryLate.TabIndex = 13;
            this.lblHistoryLate.Text = "-- minutes late --";
            this.lblHistoryLate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(6, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryDate
            // 
            this.lblHistoryDate.AutoSize = true;
            this.lblHistoryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryDate.Location = new System.Drawing.Point(169, 182);
            this.lblHistoryDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryDate.Name = "lblHistoryDate";
            this.lblHistoryDate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryDate.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryDate.TabIndex = 11;
            this.lblHistoryDate.Text = "-- date --";
            this.lblHistoryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHistoryPay
            // 
            this.lblHistoryPay.AutoSize = true;
            this.lblHistoryPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryPay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryPay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryPay.Location = new System.Drawing.Point(169, 146);
            this.lblHistoryPay.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryPay.Name = "lblHistoryPay";
            this.lblHistoryPay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryPay.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryPay.TabIndex = 10;
            this.lblHistoryPay.Text = "-- estimated pay --";
            this.lblHistoryPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHistoryWorkHours
            // 
            this.lblHistoryWorkHours.AutoSize = true;
            this.lblHistoryWorkHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryWorkHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryWorkHours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryWorkHours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryWorkHours.Location = new System.Drawing.Point(169, 110);
            this.lblHistoryWorkHours.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryWorkHours.Name = "lblHistoryWorkHours";
            this.lblHistoryWorkHours.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryWorkHours.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryWorkHours.TabIndex = 7;
            this.lblHistoryWorkHours.Text = "-- hours --";
            this.lblHistoryWorkHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Work Hours:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryTimeOut
            // 
            this.lblHistoryTimeOut.AutoSize = true;
            this.lblHistoryTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryTimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryTimeOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTimeOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryTimeOut.Location = new System.Drawing.Point(169, 74);
            this.lblHistoryTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryTimeOut.Name = "lblHistoryTimeOut";
            this.lblHistoryTimeOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryTimeOut.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryTimeOut.TabIndex = 5;
            this.lblHistoryTimeOut.Text = "-- time out --";
            this.lblHistoryTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHistoryAttendance
            // 
            this.lblHistoryAttendance.AutoSize = true;
            this.lblHistoryAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryAttendance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryAttendance.Location = new System.Drawing.Point(169, 38);
            this.lblHistoryAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryAttendance.Name = "lblHistoryAttendance";
            this.lblHistoryAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryAttendance.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryAttendance.TabIndex = 3;
            this.lblHistoryAttendance.Text = "-- status --";
            this.lblHistoryAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Margin = new System.Windows.Forms.Padding(6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Attendance Status:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryTimeIn
            // 
            this.lblHistoryTimeIn.AutoSize = true;
            this.lblHistoryTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHistoryTimeIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryTimeIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTimeIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryTimeIn.Location = new System.Drawing.Point(169, 2);
            this.lblHistoryTimeIn.Margin = new System.Windows.Forms.Padding(2);
            this.lblHistoryTimeIn.Name = "lblHistoryTimeIn";
            this.lblHistoryTimeIn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHistoryTimeIn.Size = new System.Drawing.Size(181, 32);
            this.lblHistoryTimeIn.TabIndex = 1;
            this.lblHistoryTimeIn.Text = "-- time in --";
            this.lblHistoryTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label17.Location = new System.Drawing.Point(6, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Time In:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 78);
            this.label18.Margin = new System.Windows.Forms.Padding(6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "Time Out:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Arial", 12F);
            this.label19.Location = new System.Drawing.Point(6, 150);
            this.label19.Margin = new System.Windows.Forms.Padding(6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 24);
            this.label19.TabIndex = 9;
            this.label19.Text = "Estimated Pay:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(87, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select date above to view your attendance history.";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(41, 225);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(388, 1);
            this.materialDivider2.TabIndex = 13;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.White;
            this.calendar.Location = new System.Drawing.Point(122, 36);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAttendanceID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.materialDivider1);
            this.groupBox1.Controls.Add(this.txtGreeting);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Attendance";
            // 
            // lblAttendanceID
            // 
            this.lblAttendanceID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceID.ForeColor = System.Drawing.Color.DimGray;
            this.lblAttendanceID.Location = new System.Drawing.Point(102, 343);
            this.lblAttendanceID.Name = "lblAttendanceID";
            this.lblAttendanceID.Size = new System.Drawing.Size(145, 14);
            this.lblAttendanceID.TabIndex = 14;
            this.lblAttendanceID.Text = "- - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(23, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Attendance ID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.10227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.89773F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMinutesLate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEstimatedPay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHoursOfWork, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHourlyPay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTimein, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 230);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial", 12F);
            this.label14.Location = new System.Drawing.Point(3, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 40);
            this.label14.TabIndex = 12;
            this.label14.Text = "Minutes Late:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinutesLate
            // 
            this.lblMinutesLate.AutoSize = true;
            this.lblMinutesLate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinutesLate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesLate.Location = new System.Drawing.Point(203, 190);
            this.lblMinutesLate.Name = "lblMinutesLate";
            this.lblMinutesLate.Size = new System.Drawing.Size(146, 40);
            this.lblMinutesLate.TabIndex = 11;
            this.lblMinutesLate.Text = "-- Minutes Late --";
            this.lblMinutesLate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstimatedPay
            // 
            this.lblEstimatedPay.AutoSize = true;
            this.lblEstimatedPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstimatedPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedPay.Location = new System.Drawing.Point(203, 152);
            this.lblEstimatedPay.Name = "lblEstimatedPay";
            this.lblEstimatedPay.Size = new System.Drawing.Size(146, 38);
            this.lblEstimatedPay.TabIndex = 10;
            this.lblEstimatedPay.Text = "-- estimated pay --";
            this.lblEstimatedPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoursOfWork
            // 
            this.lblHoursOfWork.AutoSize = true;
            this.lblHoursOfWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoursOfWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursOfWork.Location = new System.Drawing.Point(203, 114);
            this.lblHoursOfWork.Name = "lblHoursOfWork";
            this.lblHoursOfWork.Size = new System.Drawing.Size(146, 38);
            this.lblHoursOfWork.TabIndex = 7;
            this.lblHoursOfWork.Text = "-- hours --";
            this.lblHoursOfWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estimated work hours:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHourlyPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPay.Location = new System.Drawing.Point(203, 76);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(146, 38);
            this.lblHourlyPay.TabIndex = 5;
            this.lblHourlyPay.Text = "-- hourly pay --";
            this.lblHourlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblStatus.Location = new System.Drawing.Point(203, 38);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 38);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "-- status --";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Attendance Status:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimein
            // 
            this.lblTimein.AutoSize = true;
            this.lblTimein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimein.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTimein.Location = new System.Drawing.Point(203, 0);
            this.lblTimein.Name = "lblTimein";
            this.lblTimein.Size = new System.Drawing.Size(146, 38);
            this.lblTimein.TabIndex = 1;
            this.lblTimein.Text = "-- time in --";
            this.lblTimein.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Time In:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hourly Pay:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(3, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 38);
            this.label10.TabIndex = 9;
            this.label10.Text = "Today\'s Estimated Pay:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 95);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(388, 1);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtGreeting
            // 
            this.txtGreeting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGreeting.Location = new System.Drawing.Point(28, 37);
            this.txtGreeting.Name = "txtGreeting";
            this.txtGreeting.Size = new System.Drawing.Size(349, 52);
            this.txtGreeting.TabIndex = 0;
            this.txtGreeting.Text = "label1";
            this.txtGreeting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 38);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTime.Location = new System.Drawing.Point(343, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 16);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "-- Date --";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(90, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "-- Date --";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(41, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.LinkColor = System.Drawing.Color.White;
            this.linkLogout.Location = new System.Drawing.Point(841, 38);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(69, 22);
            this.linkLogout.TabIndex = 1;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOvertime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOvertime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOvertime.Location = new System.Drawing.Point(169, 254);
            this.lblOvertime.Margin = new System.Windows.Forms.Padding(2);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOvertime.Size = new System.Drawing.Size(181, 36);
            this.lblOvertime.TabIndex = 15;
            this.lblOvertime.Text = "-- minutes late --";
            this.lblOvertime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Arial", 12F);
            this.label21.Location = new System.Drawing.Point(6, 258);
            this.label21.Margin = new System.Windows.Forms.Padding(6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(155, 28);
            this.label21.TabIndex = 16;
            this.label21.Text = "Overtime Hours:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.label13.Location = new System.Drawing.Point(15, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(378, 44);
            this.label13.TabIndex = 18;
            this.label13.Text = "Note: 1 hour deduction on your work hours for break time.";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 10;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timeDate;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAttendanceID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEstimatedPay;
        private System.Windows.Forms.Label lblHoursOfWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label txtGreeting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHistoryPay;
        private System.Windows.Forms.Label lblHistoryWorkHours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHistoryAttendance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblHistoryTimeIn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label lblHistoryTimeOut;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHistoryDate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMinutesLate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblHistoryLate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label label13;
    }
}