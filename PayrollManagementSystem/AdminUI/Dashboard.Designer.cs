namespace PayrollManagementSystem.AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnModifyEmployee = new MaterialSkin.Controls.MaterialButton();
            this.btnAddEmployee = new MaterialSkin.Controls.MaterialButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtDate = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.Label();
            this.txtGreeting = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "payroll.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1257, 552);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Payroll";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.btnModifyEmployee);
            this.tabPage3.Controls.Add(this.btnAddEmployee);
            this.tabPage3.Controls.Add(this.panelContainer);
            this.tabPage3.ImageKey = "user.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1257, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(370, 546);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(172, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clean Dashboard";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.AutoSize = false;
            this.btnModifyEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifyEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModifyEmployee.Depth = 0;
            this.btnModifyEmployee.HighEmphasis = true;
            this.btnModifyEmployee.Icon = null;
            this.btnModifyEmployee.Location = new System.Drawing.Point(190, 546);
            this.btnModifyEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModifyEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModifyEmployee.Size = new System.Drawing.Size(172, 40);
            this.btnModifyEmployee.TabIndex = 2;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModifyEmployee.UseAccentColor = false;
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AutoSize = false;
            this.btnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddEmployee.Depth = 0;
            this.btnAddEmployee.HighEmphasis = true;
            this.btnAddEmployee.Icon = null;
            this.btnAddEmployee.Location = new System.Drawing.Point(10, 546);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddEmployee.Size = new System.Drawing.Size(172, 40);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddEmployee.UseAccentColor = false;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1257, 537);
            this.panelContainer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "identity-card.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1257, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "dashboard.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1257, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Controls.Add(this.tabPage3);
            this.tabContainer.Controls.Add(this.tabPage4);
            this.tabContainer.Depth = 0;
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.ImageList = this.imageList1;
            this.tabContainer.Location = new System.Drawing.Point(0, 72);
            this.tabContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabContainer.Multiline = true;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1265, 595);
            this.tabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContainer.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "payroll.png");
            this.imageList1.Images.SetKeyName(1, "dashboard.png");
            this.imageList1.Images.SetKeyName(2, "division.png");
            this.imageList1.Images.SetKeyName(3, "identity-card.png");
            this.imageList1.Images.SetKeyName(4, "salary.png");
            this.imageList1.Images.SetKeyName(5, "stakeholder.png");
            this.imageList1.Images.SetKeyName(6, "user.png");
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(786, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(232, 16);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "label1";
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(786, 48);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(232, 16);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "label1";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGreeting
            // 
            this.txtGreeting.BackColor = System.Drawing.Color.Transparent;
            this.txtGreeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreeting.ForeColor = System.Drawing.Color.White;
            this.txtGreeting.Location = new System.Drawing.Point(1024, 30);
            this.txtGreeting.Name = "txtGreeting";
            this.txtGreeting.Size = new System.Drawing.Size(232, 34);
            this.txtGreeting.TabIndex = 3;
            this.txtGreeting.Text = "label1";
            this.txtGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "dashboard.png");
            this.imageList2.Images.SetKeyName(1, "division.png");
            this.imageList2.Images.SetKeyName(2, "attendance.png");
            this.imageList2.Images.SetKeyName(3, "payroll.png");
            this.imageList2.Images.SetKeyName(4, "stakeholder.png");
            this.imageList2.Images.SetKeyName(5, "employee.png");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 670);
            this.Controls.Add(this.txtGreeting);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.tabContainer);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 10;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabContainer;
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Dashboard";
            this.tabPage3.ResumeLayout(false);
            this.tabContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabControl tabContainer;
        private MaterialSkin.Controls.MaterialButton btnAddEmployee;
        private System.Windows.Forms.Panel panelContainer;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnModifyEmployee;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Timer dateTime;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtGreeting;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}