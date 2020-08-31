namespace Login_Signup
{
    partial class Departments
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
            this.theShoppingMallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theShoppingMallDataSet = new Login_Signup.TheShoppingMallDataSet();
            this.menuButton = new System.Windows.Forms.Button();
            this.departmentTable = new System.Windows.Forms.DataGridView();
            this.depidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTable)).BeginInit();
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
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.SkyBlue;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(20, 18);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(74, 36);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // departmentTable
            // 
            this.departmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depidCol,
            this.depnameCol,
            this.manidCol});
            this.departmentTable.Location = new System.Drawing.Point(196, 78);
            this.departmentTable.Name = "departmentTable";
            this.departmentTable.Size = new System.Drawing.Size(343, 219);
            this.departmentTable.TabIndex = 2;
            this.departmentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // depidCol
            // 
            this.depidCol.HeaderText = "Department Id";
            this.depidCol.Name = "depidCol";
            // 
            // depnameCol
            // 
            this.depnameCol.HeaderText = "Name";
            this.depnameCol.Name = "depnameCol";
            // 
            // manidCol
            // 
            this.manidCol.HeaderText = "Manager ID";
            this.manidCol.Name = "manidCol";
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.https_2F2Fblueprint_api_production_s3_amazonaws_com2Fuploads2Fcard2Fimage2F8470672F995c27df_12fb_4cba_b2bc_59235461a038;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.departmentTable);
            this.Controls.Add(this.menuButton);
            this.DoubleBuffered = true;
            this.Name = "Departments";
            this.Text = "Departmentscs";
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource theShoppingMallDataSetBindingSource;
        private TheShoppingMallDataSet theShoppingMallDataSet;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView departmentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn depidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn manidCol;
    }
}