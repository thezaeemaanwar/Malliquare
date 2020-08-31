namespace Login_Signup
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.productTable = new System.Windows.Forms.DataGridView();
            this.pidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costpriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promonameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchproductField = new System.Windows.Forms.TextBox();
            this.searchproductButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.allproButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.BackgroundColor = System.Drawing.Color.Salmon;
            this.productTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "NULL";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidCol,
            this.pnameCol,
            this.costpriceCol,
            this.gstCol,
            this.salepriceCol,
            this.promonameCol,
            this.promoCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.productTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.productTable, "productTable");
            this.productTable.Name = "productTable";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.productTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pidCol
            // 
            resources.ApplyResources(this.pidCol, "pidCol");
            this.pidCol.Name = "pidCol";
            // 
            // pnameCol
            // 
            resources.ApplyResources(this.pnameCol, "pnameCol");
            this.pnameCol.Name = "pnameCol";
            // 
            // costpriceCol
            // 
            resources.ApplyResources(this.costpriceCol, "costpriceCol");
            this.costpriceCol.Name = "costpriceCol";
            // 
            // gstCol
            // 
            resources.ApplyResources(this.gstCol, "gstCol");
            this.gstCol.Name = "gstCol";
            // 
            // salepriceCol
            // 
            resources.ApplyResources(this.salepriceCol, "salepriceCol");
            this.salepriceCol.Name = "salepriceCol";
            // 
            // promonameCol
            // 
            resources.ApplyResources(this.promonameCol, "promonameCol");
            this.promonameCol.Name = "promonameCol";
            // 
            // promoCol
            // 
            resources.ApplyResources(this.promoCol, "promoCol");
            this.promoCol.Name = "promoCol";
            // 
            // searchproductField
            // 
            resources.ApplyResources(this.searchproductField, "searchproductField");
            this.searchproductField.Name = "searchproductField";
            this.searchproductField.TextChanged += new System.EventHandler(this.searchproductField_TextChanged);
            this.searchproductField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchproductField_KeyPress);
            // 
            // searchproductButton
            // 
            this.searchproductButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.searchproductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchproductButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchproductButton, "searchproductButton");
            this.searchproductButton.Name = "searchproductButton";
            this.searchproductButton.UseVisualStyleBackColor = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Salmon;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Name = "menuButton";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // allproButton
            // 
            this.allproButton.BackColor = System.Drawing.Color.Salmon;
            this.allproButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allproButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.allproButton, "allproButton");
            this.allproButton.ForeColor = System.Drawing.Color.White;
            this.allproButton.Name = "allproButton";
            this.allproButton.UseVisualStyleBackColor = false;
            this.allproButton.Click += new System.EventHandler(this.allproButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Salmon;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // products
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.shopping_cart;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.allproButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.searchproductButton);
            this.Controls.Add(this.searchproductField);
            this.Controls.Add(this.productTable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "products";
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.TextBox searchproductField;
        private System.Windows.Forms.Button searchproductButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costpriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn promonameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn promoCol;
        private System.Windows.Forms.Button allproButton;
        private System.Windows.Forms.Button searchButton;
    }
}