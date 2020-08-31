using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class Departments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");
        public Departments()
        {
            InitializeComponent();
            populateData();
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Black;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.SkyBlue;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new nav().Show();
            this.Close();
        }
        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Departments", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            departmentTable.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string man_id = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                
                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(departmentTable);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = man_id;
                
                departmentTable.Rows.Add(row1);
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
