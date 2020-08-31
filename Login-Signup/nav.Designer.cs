namespace Login_Signup
{
    partial class nav
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
            this.newsaleButton = new System.Windows.Forms.Button();
            this.viewdepButton = new System.Windows.Forms.Button();
            this.addproButton = new System.Windows.Forms.Button();
            this.viewproButton = new System.Windows.Forms.Button();
            this.updateempButton = new System.Windows.Forms.Button();
            this.viewempButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newsaleButton
            // 
            this.newsaleButton.BackColor = System.Drawing.Color.Teal;
            this.newsaleButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsaleButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.newsaleButton.Location = new System.Drawing.Point(431, 226);
            this.newsaleButton.Name = "newsaleButton";
            this.newsaleButton.Size = new System.Drawing.Size(261, 77);
            this.newsaleButton.TabIndex = 0;
            this.newsaleButton.Text = "Start new sale";
            this.newsaleButton.UseVisualStyleBackColor = false;
            this.newsaleButton.Click += new System.EventHandler(this.newsaleButton_Click);
            this.newsaleButton.MouseEnter += new System.EventHandler(this.newsaleButton_MouseEnter);
            this.newsaleButton.MouseLeave += new System.EventHandler(this.newsaleButton_MouseLeave);
            // 
            // viewdepButton
            // 
            this.viewdepButton.BackColor = System.Drawing.Color.Teal;
            this.viewdepButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdepButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.viewdepButton.Location = new System.Drawing.Point(698, 226);
            this.viewdepButton.Name = "viewdepButton";
            this.viewdepButton.Size = new System.Drawing.Size(273, 77);
            this.viewdepButton.TabIndex = 1;
            this.viewdepButton.Text = "View all Departments";
            this.viewdepButton.UseVisualStyleBackColor = false;
            this.viewdepButton.Click += new System.EventHandler(this.viewdepButton_Click);
            this.viewdepButton.MouseEnter += new System.EventHandler(this.viewdepButton_MouseEnter);
            this.viewdepButton.MouseLeave += new System.EventHandler(this.viewdepButton_MouseLeave);
            // 
            // addproButton
            // 
            this.addproButton.BackColor = System.Drawing.Color.Tomato;
            this.addproButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.addproButton.Location = new System.Drawing.Point(698, 320);
            this.addproButton.Name = "addproButton";
            this.addproButton.Size = new System.Drawing.Size(273, 77);
            this.addproButton.TabIndex = 3;
            this.addproButton.Text = "Add/Update Product";
            this.addproButton.UseVisualStyleBackColor = false;
            this.addproButton.Click += new System.EventHandler(this.addproductButton_Click);
            this.addproButton.MouseEnter += new System.EventHandler(this.addproButton_MouseEnter);
            this.addproButton.MouseLeave += new System.EventHandler(this.addproButton_MouseLeave);
            // 
            // viewproButton
            // 
            this.viewproButton.BackColor = System.Drawing.Color.Tomato;
            this.viewproButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewproButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.viewproButton.Location = new System.Drawing.Point(431, 320);
            this.viewproButton.Name = "viewproButton";
            this.viewproButton.Size = new System.Drawing.Size(261, 77);
            this.viewproButton.TabIndex = 2;
            this.viewproButton.Text = "View All Products";
            this.viewproButton.UseVisualStyleBackColor = false;
            this.viewproButton.Click += new System.EventHandler(this.viewproductsButton_Click);
            this.viewproButton.MouseEnter += new System.EventHandler(this.viewproButton_MouseEnter);
            this.viewproButton.MouseLeave += new System.EventHandler(this.viewproButton_MouseLeave);
            // 
            // updateempButton
            // 
            this.updateempButton.BackColor = System.Drawing.Color.MistyRose;
            this.updateempButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateempButton.ForeColor = System.Drawing.Color.Black;
            this.updateempButton.Location = new System.Drawing.Point(698, 414);
            this.updateempButton.Name = "updateempButton";
            this.updateempButton.Size = new System.Drawing.Size(273, 77);
            this.updateempButton.TabIndex = 5;
            this.updateempButton.Text = "Add/Update Employees";
            this.updateempButton.UseVisualStyleBackColor = false;
            this.updateempButton.Click += new System.EventHandler(this.updateempButton_Click);
            this.updateempButton.MouseEnter += new System.EventHandler(this.updateempButton_MouseEnter);
            this.updateempButton.MouseLeave += new System.EventHandler(this.updateempButton_MouseLeave);
            // 
            // viewempButton
            // 
            this.viewempButton.BackColor = System.Drawing.Color.MistyRose;
            this.viewempButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewempButton.ForeColor = System.Drawing.Color.Black;
            this.viewempButton.Location = new System.Drawing.Point(431, 414);
            this.viewempButton.Name = "viewempButton";
            this.viewempButton.Size = new System.Drawing.Size(261, 77);
            this.viewempButton.TabIndex = 4;
            this.viewempButton.Text = "View all Employees";
            this.viewempButton.UseVisualStyleBackColor = false;
            this.viewempButton.Click += new System.EventHandler(this.viewempButton_Click);
            this.viewempButton.MouseEnter += new System.EventHandler(this.viewempButton_MouseEnter);
            this.viewempButton.MouseLeave += new System.EventHandler(this.viewempButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MistyRose;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(887, 512);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(431, 512);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(106, 46);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.logoutButton_MouseEnter);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            // 
            // nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.backrutgjh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateempButton);
            this.Controls.Add(this.viewempButton);
            this.Controls.Add(this.addproButton);
            this.Controls.Add(this.viewproButton);
            this.Controls.Add(this.viewdepButton);
            this.Controls.Add(this.newsaleButton);
            this.Name = "nav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newsaleButton;
        private System.Windows.Forms.Button viewdepButton;
        private System.Windows.Forms.Button addproButton;
        private System.Windows.Forms.Button viewproButton;
        private System.Windows.Forms.Button updateempButton;
        private System.Windows.Forms.Button viewempButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
    }
}