namespace Login_Signup
{
    partial class AddEmp
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cnicLabel = new System.Windows.Forms.Label();
            this.empifLabel = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.TextBox();
            this.lastnameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.addempButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.empidField = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobField = new System.Windows.Forms.DateTimePicker();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.cpasswordField = new System.Windows.Forms.TextBox();
            this.cpassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.salaryField = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.cnicField = new System.Windows.Forms.MaskedTextBox();
            this.deleteEmpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.fnameLabel.Location = new System.Drawing.Point(433, 105);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(79, 19);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.lnameLabel.Location = new System.Drawing.Point(857, 104);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(81, 19);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Indigo;
            this.emailLabel.Location = new System.Drawing.Point(448, 230);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 19);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // cnicLabel
            // 
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.BackColor = System.Drawing.Color.Transparent;
            this.cnicLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicLabel.ForeColor = System.Drawing.Color.Indigo;
            this.cnicLabel.Location = new System.Drawing.Point(857, 230);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(70, 19);
            this.cnicLabel.TabIndex = 3;
            this.cnicLabel.Text = "CNIC no.";
            this.cnicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empifLabel
            // 
            this.empifLabel.AutoSize = true;
            this.empifLabel.BackColor = System.Drawing.Color.Transparent;
            this.empifLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empifLabel.ForeColor = System.Drawing.Color.Indigo;
            this.empifLabel.Location = new System.Drawing.Point(425, 167);
            this.empifLabel.Name = "empifLabel";
            this.empifLabel.Size = new System.Drawing.Size(95, 19);
            this.empifLabel.TabIndex = 4;
            this.empifLabel.Text = "Employee Id";
            this.empifLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empifLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // firstnameField
            // 
            this.firstnameField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.firstnameField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameField.Location = new System.Drawing.Point(323, 131);
            this.firstnameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Size = new System.Drawing.Size(349, 24);
            this.firstnameField.TabIndex = 0;
            this.firstnameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastnameField
            // 
            this.lastnameField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lastnameField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameField.Location = new System.Drawing.Point(720, 131);
            this.lastnameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnameField.Name = "lastnameField";
            this.lastnameField.Size = new System.Drawing.Size(350, 24);
            this.lastnameField.TabIndex = 1;
            this.lastnameField.TextChanged += new System.EventHandler(this.lastnameField_TextChanged);
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.emailField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(326, 259);
            this.emailField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(348, 24);
            this.emailField.TabIndex = 4;
            this.emailField.TextChanged += new System.EventHandler(this.emailField_TextChanged);
            // 
            // addempButton
            // 
            this.addempButton.BackColor = System.Drawing.Color.Indigo;
            this.addempButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addempButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addempButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.addempButton.FlatAppearance.BorderSize = 0;
            this.addempButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.addempButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addempButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.addempButton.Location = new System.Drawing.Point(976, 444);
            this.addempButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addempButton.Name = "addempButton";
            this.addempButton.Size = new System.Drawing.Size(96, 55);
            this.addempButton.TabIndex = 9;
            this.addempButton.Text = "Add";
            this.addempButton.UseVisualStyleBackColor = false;
            this.addempButton.Click += new System.EventHandler(this.signup_button_Click);
            this.addempButton.MouseEnter += new System.EventHandler(this.addempButton_MouseEnter);
            this.addempButton.MouseLeave += new System.EventHandler(this.addempButton_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vivaldi", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(516, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "The Shopping Mall";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // empidField
            // 
            this.empidField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.empidField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidField.Location = new System.Drawing.Point(323, 194);
            this.empidField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empidField.Name = "empidField";
            this.empidField.Size = new System.Drawing.Size(348, 24);
            this.empidField.TabIndex = 2;
            this.empidField.TextChanged += new System.EventHandler(this.empidField2_TextChanged);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.Indigo;
            this.dobLabel.Location = new System.Drawing.Point(841, 167);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(93, 19);
            this.dobLabel.TabIndex = 14;
            this.dobLabel.Text = "Date of Birth";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobField
            // 
            this.dobField.CalendarFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobField.CalendarMonthBackground = System.Drawing.Color.BlanchedAlmond;
            this.dobField.CalendarTitleBackColor = System.Drawing.Color.BlanchedAlmond;
            this.dobField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobField.Location = new System.Drawing.Point(719, 193);
            this.dobField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dobField.Name = "dobField";
            this.dobField.ShowUpDown = true;
            this.dobField.Size = new System.Drawing.Size(349, 24);
            this.dobField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(323, 328);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(348, 24);
            this.passwordField.TabIndex = 6;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cpasswordField
            // 
            this.cpasswordField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cpasswordField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpasswordField.Location = new System.Drawing.Point(720, 328);
            this.cpasswordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cpasswordField.Name = "cpasswordField";
            this.cpasswordField.Size = new System.Drawing.Size(349, 24);
            this.cpasswordField.TabIndex = 7;
            this.cpasswordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cpassLabel
            // 
            this.cpassLabel.AutoSize = true;
            this.cpassLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpassLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpassLabel.ForeColor = System.Drawing.Color.Indigo;
            this.cpassLabel.Location = new System.Drawing.Point(826, 299);
            this.cpassLabel.Name = "cpassLabel";
            this.cpassLabel.Size = new System.Drawing.Size(129, 19);
            this.cpassLabel.TabIndex = 17;
            this.cpassLabel.Text = "Confirm Password";
            this.cpassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpassLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Indigo;
            this.passLabel.Location = new System.Drawing.Point(408, 299);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(124, 19);
            this.passLabel.TabIndex = 16;
            this.passLabel.Text = "Create Password";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // salaryField
            // 
            this.salaryField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.salaryField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryField.Location = new System.Drawing.Point(721, 397);
            this.salaryField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryField.Name = "salaryField";
            this.salaryField.Size = new System.Drawing.Size(349, 24);
            this.salaryField.TabIndex = 9;
            this.salaryField.TextChanged += new System.EventHandler(this.salaryField_TextChanged);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.salaryLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.Color.Indigo;
            this.salaryLabel.Location = new System.Drawing.Point(870, 368);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(51, 19);
            this.salaryLabel.TabIndex = 21;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.BackColor = System.Drawing.Color.Transparent;
            this.department.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.Color.Indigo;
            this.department.Location = new System.Drawing.Point(425, 368);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(93, 19);
            this.department.TabIndex = 20;
            this.department.Text = "Department";
            this.department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentField
            // 
            this.departmentField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.departmentField.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Items.AddRange(new object[] {
            "Management",
            "Sales",
            "Purchase",
            "Accounts"});
            this.departmentField.Location = new System.Drawing.Point(326, 399);
            this.departmentField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(347, 24);
            this.departmentField.TabIndex = 8;
            this.departmentField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.departmentField_KeyUp);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Indigo;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.updateButton.Location = new System.Drawing.Point(326, 444);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 55);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.updateButton.MouseEnter += new System.EventHandler(this.updateButton_MouseEnter);
            this.updateButton.MouseLeave += new System.EventHandler(this.updateButton_MouseLeave);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Indigo;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.menuButton.Location = new System.Drawing.Point(22, 17);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(99, 55);
            this.menuButton.TabIndex = 23;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // cnicField
            // 
            this.cnicField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cnicField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicField.Location = new System.Drawing.Point(720, 259);
            this.cnicField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnicField.Mask = " 99999 - 9999999 - 9";
            this.cnicField.Name = "cnicField";
            this.cnicField.Size = new System.Drawing.Size(350, 24);
            this.cnicField.TabIndex = 24;
            // 
            // deleteEmpButton
            // 
            this.deleteEmpButton.BackColor = System.Drawing.Color.Indigo;
            this.deleteEmpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEmpButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.deleteEmpButton.FlatAppearance.BorderSize = 0;
            this.deleteEmpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.deleteEmpButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmpButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.deleteEmpButton.Location = new System.Drawing.Point(437, 444);
            this.deleteEmpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(99, 55);
            this.deleteEmpButton.TabIndex = 25;
            this.deleteEmpButton.Text = "Delete";
            this.deleteEmpButton.UseVisualStyleBackColor = false;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.shop55;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.deleteEmpButton);
            this.Controls.Add(this.cnicField);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.salaryField);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.department);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.cpasswordField);
            this.Controls.Add(this.cpassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dobField);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.empidField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addempButton);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.lastnameField);
            this.Controls.Add(this.firstnameField);
            this.Controls.Add(this.empifLabel);
            this.Controls.Add(this.cnicLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEmp";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.MouseEnter += new System.EventHandler(this.AddEmp_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label cnicLabel;
        private System.Windows.Forms.Label empifLabel;
        private System.Windows.Forms.TextBox firstnameField;
        private System.Windows.Forms.TextBox lastnameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button addempButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empidField;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox cpasswordField;
        private System.Windows.Forms.Label cpassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox salaryField;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.ComboBox departmentField;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.MaskedTextBox cnicField;
        private System.Windows.Forms.Button deleteEmpButton;
    }
}