namespace Login_Signup
{
    partial class employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.theShoppingMallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theShoppingMallDataSet = new Login_Signup.TheShoppingMallDataSet();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.empTable = new System.Windows.Forms.DataGridView();
            this.eidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.didCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dojCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vallempButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).BeginInit();
            this.SuspendLayout();
            // 
            // theShoppingMallDataSetBindingSource
            // 
            this.theShoppingMallDataSetBindingSource.DataSource = this.theShoppingMallDataSet;
            this.theShoppingMallDataSetBindingSource.Position = 0;
            // 
            // theShoppingMallDataSet
            // 
            this.theShoppingMallDataSet.DataSetName = "TheShoppingMallDataSet";
            this.theShoppingMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SlateGray;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(974, 87);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 41);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchButton_KeyUp);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.MintCream;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(682, 95);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(286, 27);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchField_KeyPress);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.SlateGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuButton.Location = new System.Drawing.Point(13, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(98, 39);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // empTable
            // 
            this.empTable.AllowUserToAddRows = false;
            this.empTable.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empTable.ColumnHeadersHeight = 40;
            this.empTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidCol,
            this.nameCol,
            this.didCol,
            this.cnicCol,
            this.mailCol,
            this.dobCol,
            this.salCol,
            this.dojCol});
            this.empTable.Location = new System.Drawing.Point(257, 149);
            this.empTable.Name = "empTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            this.empTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.empTable.Size = new System.Drawing.Size(843, 321);
            this.empTable.TabIndex = 5;
            // 
            // eidCol
            // 
            this.eidCol.HeaderText = "Emp ID";
            this.eidCol.Name = "eidCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            // 
            // didCol
            // 
            this.didCol.HeaderText = "Department";
            this.didCol.Name = "didCol";
            // 
            // cnicCol
            // 
            this.cnicCol.HeaderText = "CNIC";
            this.cnicCol.Name = "cnicCol";
            // 
            // mailCol
            // 
            this.mailCol.HeaderText = "E-Mail";
            this.mailCol.Name = "mailCol";
            // 
            // dobCol
            // 
            this.dobCol.HeaderText = "DOB";
            this.dobCol.Name = "dobCol";
            // 
            // salCol
            // 
            this.salCol.HeaderText = "Salary";
            this.salCol.Name = "salCol";
            // 
            // dojCol
            // 
            this.dojCol.HeaderText = "Joining Date";
            this.dojCol.Name = "dojCol";
            // 
            // vallempButton
            // 
            this.vallempButton.BackColor = System.Drawing.Color.SlateGray;
            this.vallempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vallempButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vallempButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vallempButton.Location = new System.Drawing.Point(313, 87);
            this.vallempButton.Name = "vallempButton";
            this.vallempButton.Size = new System.Drawing.Size(163, 41);
            this.vallempButton.TabIndex = 2;
            this.vallempButton.Text = "View All";
            this.vallempButton.UseVisualStyleBackColor = false;
            this.vallempButton.Click += new System.EventHandler(this.vallempButton_Click);
            this.vallempButton.MouseEnter += new System.EventHandler(this.vallempButton_MouseEnter);
            this.vallempButton.MouseLeave += new System.EventHandler(this.vallempButton_MouseLeave);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.Watch_Dogs_2_Marcus_wallpaper_10929323;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.vallempButton);
            this.Controls.Add(this.empTable);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchField);
            this.Name = "employees";
            this.Text = "Employees in Mall";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.BindingSource theShoppingMallDataSetBindingSource;
        private TheShoppingMallDataSet theShoppingMallDataSet;
        private System.Windows.Forms.DataGridView empTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn didCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salCol;
        private System.Windows.Forms.Button vallempButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dojCol;
    }
}