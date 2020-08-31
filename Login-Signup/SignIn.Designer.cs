namespace Login_Signup
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empidField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.signinButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(181, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(170, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // empidField
            // 
            this.empidField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.empidField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidField.ForeColor = System.Drawing.Color.Indigo;
            this.empidField.Location = new System.Drawing.Point(115, 123);
            this.empidField.Name = "empidField";
            this.empidField.Size = new System.Drawing.Size(185, 26);
            this.empidField.TabIndex = 2;
            this.empidField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.empidField.Click += new System.EventHandler(this.userid_Click);
            this.empidField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.empidField.MouseHover += new System.EventHandler(this.userid_MouseHover);
            this.empidField.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.userid_ChangeUICues);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.Indigo;
            this.passwordField.Location = new System.Drawing.Point(116, 174);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(185, 26);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.Indigo;
            this.signinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.signinButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.signinButton.Location = new System.Drawing.Point(245, 218);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(55, 29);
            this.signinButton.TabIndex = 4;
            this.signinButton.Text = "SignIn";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.button1_Click);
            this.signinButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.signinButton.MouseLeave += new System.EventHandler(this.signinButton_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vivaldi", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(62, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "The Shopping Mall";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Indigo;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.exitButton.Location = new System.Drawing.Point(115, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 29);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.shop53;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 420);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.empidField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empidField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
    }
}

