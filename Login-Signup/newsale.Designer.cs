namespace Login_Signup
{
    partial class newsale
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
            this.menuButton = new System.Windows.Forms.Button();
            this.pidField = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.billTable = new System.Windows.Forms.DataGridView();
            this.pid2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recField = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.nsaleButton = new System.Windows.Forms.Button();
            this.retButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Maroon;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.menuButton.Location = new System.Drawing.Point(13, 13);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 33);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button1_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // pidField
            // 
            this.pidField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pidField.Location = new System.Drawing.Point(394, 117);
            this.pidField.Name = "pidField";
            this.pidField.Size = new System.Drawing.Size(207, 23);
            this.pidField.TabIndex = 1;
            this.pidField.Text = "Enter product code here";
            this.pidField.Click += new System.EventHandler(this.pid2Field_Click);
            this.pidField.TextChanged += new System.EventHandler(this.pid2Field_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Maroon;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterButton.Location = new System.Drawing.Point(792, 108);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 40);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.button2_Click);
            this.enterButton.MouseEnter += new System.EventHandler(this.enterButton_MouseEnter);
            this.enterButton.MouseLeave += new System.EventHandler(this.enterButton_MouseLeave);
            // 
            // billTable
            // 
            this.billTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid2Col,
            this.pname2Col,
            this.gst2Col,
            this.price2Col,
            this.qty2Col,
            this.tpriceCol});
            this.billTable.Location = new System.Drawing.Point(361, 165);
            this.billTable.Name = "billTable";
            this.billTable.Size = new System.Drawing.Size(645, 308);
            this.billTable.TabIndex = 3;
            // 
            // pid2Col
            // 
            this.pid2Col.HeaderText = "Product Code";
            this.pid2Col.Name = "pid2Col";
            // 
            // pname2Col
            // 
            this.pname2Col.HeaderText = "Product Name";
            this.pname2Col.Name = "pname2Col";
            // 
            // gst2Col
            // 
            this.gst2Col.HeaderText = "GST";
            this.gst2Col.Name = "gst2Col";
            // 
            // price2Col
            // 
            this.price2Col.HeaderText = "Sales Price";
            this.price2Col.Name = "price2Col";
            // 
            // qty2Col
            // 
            this.qty2Col.HeaderText = "Quantity";
            this.qty2Col.Name = "qty2Col";
            // 
            // tpriceCol
            // 
            this.tpriceCol.HeaderText = "Total";
            this.tpriceCol.Name = "tpriceCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyField
            // 
            this.qtyField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.qtyField.Location = new System.Drawing.Point(617, 117);
            this.qtyField.Name = "qtyField";
            this.qtyField.Size = new System.Drawing.Size(169, 23);
            this.qtyField.TabIndex = 6;
            this.qtyField.Text = "Quantity";
            this.qtyField.Click += new System.EventHandler(this.qty2Field_Click);
            this.qtyField.TextChanged += new System.EventHandler(this.qty2Field_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cash Returned";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cash Recieved";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recField
            // 
            this.recField.ForeColor = System.Drawing.Color.Black;
            this.recField.Location = new System.Drawing.Point(801, 531);
            this.recField.Margin = new System.Windows.Forms.Padding(0);
            this.recField.Name = "recField";
            this.recField.Size = new System.Drawing.Size(100, 20);
            this.recField.TabIndex = 10;
            this.recField.Text = "00.00 Rs";
            this.recField.Click += new System.EventHandler(this.recField_Click);
            this.recField.TextChanged += new System.EventHandler(this.recField_TextChanged);
            this.recField.DoubleClick += new System.EventHandler(this.recField_DoubleClick);
            this.recField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recField_KeyPress);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(361, 598);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // nsaleButton
            // 
            this.nsaleButton.BackColor = System.Drawing.Color.Maroon;
            this.nsaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nsaleButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsaleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nsaleButton.Location = new System.Drawing.Point(801, 598);
            this.nsaleButton.Name = "nsaleButton";
            this.nsaleButton.Size = new System.Drawing.Size(100, 35);
            this.nsaleButton.TabIndex = 11;
            this.nsaleButton.Text = "New Sale";
            this.nsaleButton.UseVisualStyleBackColor = false;
            this.nsaleButton.Click += new System.EventHandler(this.nsaleButton_Click);
            this.nsaleButton.MouseEnter += new System.EventHandler(this.nsaleButton_MouseEnter);
            this.nsaleButton.MouseLeave += new System.EventHandler(this.nsaleButton_MouseLeave);
            // 
            // retButton
            // 
            this.retButton.BackColor = System.Drawing.Color.White;
            this.retButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retButton.Location = new System.Drawing.Point(799, 565);
            this.retButton.Margin = new System.Windows.Forms.Padding(0);
            this.retButton.Name = "retButton";
            this.retButton.Size = new System.Drawing.Size(102, 23);
            this.retButton.TabIndex = 13;
            this.retButton.Text = "00.00Rs";
            this.retButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.retButton.UseVisualStyleBackColor = false;
            this.retButton.Click += new System.EventHandler(this.retButton_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.White;
            this.billButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.billButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billButton.Location = new System.Drawing.Point(798, 496);
            this.billButton.Margin = new System.Windows.Forms.Padding(0);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(102, 24);
            this.billButton.TabIndex = 13;
            this.billButton.Text = "00.00Rs";
            this.billButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.Maroon;
            this.abortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abortButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abortButton.Location = new System.Drawing.Point(695, 598);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(100, 35);
            this.abortButton.TabIndex = 14;
            this.abortButton.Text = "Abort Sale";
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // newsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.F2pW4A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.retButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nsaleButton);
            this.Controls.Add(this.recField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtyField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billTable);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.pidField);
            this.Controls.Add(this.menuButton);
            this.Name = "newsale";
            this.Text = "newsale";
            this.Load += new System.EventHandler(this.newsale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox pidField;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView billTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty2Col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox recField;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceCol;
        private System.Windows.Forms.Button nsaleButton;
        private System.Windows.Forms.Button retButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Button abortButton;
    }
}