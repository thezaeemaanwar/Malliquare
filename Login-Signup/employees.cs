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
    public partial class employees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True;MultipleActiveResultSets=true;");

        public employees()
        {
            InitializeComponent();
            populateData();
        }

        private void employees_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new nav().Show();
            this.Hide();
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BackColor = System.Drawing.Color.HotPink;
            searchButton.ForeColor = System.Drawing.Color.Black;
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BackColor = System.Drawing.Color.SlateGray;
            searchButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.HotPink;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.SlateGray;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees_data", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            empTable.Rows.Clear();

            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string d_id = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string pass = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string cnic = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                string dob = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                string sal = ds.Tables[0].Rows[i].ItemArray[8].ToString();

                string name = fname + " " + lname;
                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(empTable);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = d_id;
                row1.Cells[3].Value = cnic;
                row1.Cells[4].Value = email;
                row1.Cells[5].Value = dob;
                row1.Cells[6].Value = sal;


                empTable.Rows.Add(row1);
            }

        }

        private void searchButton_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void search()
        {

            string search = searchField.Text;
            int cn;

            
            if (searchField.Text == "")
                MessageBox.Show("Do you have a write_Permission_Only ? \n Cuz I can't read your Mind");
            else
            {
                if (IsDigitsOnly(search))
                {
                    cn = int.Parse(search);
                }
                else
                {
                    cn = 0;
                }
                con.Open();


                string query = "Select * from Employees_data where employee_id=@search OR  firstname LIKE '%'+@search+'%' OR lastname LIKE '%'+@search+'%' OR CNIC=@search";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@cn", cn);

                SqlDataReader read = cmd.ExecuteReader();
                bool hasRows = read.HasRows;
                con.Close();
                if (hasRows)
                {
                    con.Open();
                    read.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    empTable.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        string fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        string lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        string d_id = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        string pass = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                        string cnic = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                        string email = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                        string dob = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                        string sal = ds.Tables[0].Rows[i].ItemArray[8].ToString();

                        string name = fname + " " + lname;
                        DataGridViewRow row1 = new DataGridViewRow();
                        row1.CreateCells(empTable);
                        row1.Cells[0].Value = id;
                        row1.Cells[1].Value = name;
                        row1.Cells[2].Value = d_id;
                        row1.Cells[3].Value = cnic;
                        row1.Cells[4].Value = email;
                        row1.Cells[5].Value = dob;
                        row1.Cells[6].Value = sal;


                        empTable.Rows.Add(row1);

                    }
                    con.Close();
                }
                
                else
                {
                    MessageBox.Show("No Such Employee !");
                    populateData();
                }
                
            }
            
        }
        

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void vallempButton_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void vallempButton_MouseEnter(object sender, EventArgs e)
        {
            vallempButton.BackColor = System.Drawing.Color.HotPink;
            vallempButton.ForeColor = System.Drawing.Color.Black;
        }

        private void vallempButton_MouseLeave(object sender, EventArgs e)
        {
            vallempButton.BackColor = System.Drawing.Color.SlateGray;
            vallempButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void searchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string search = searchField.Text;
            int cn;


                if (IsDigitsOnly(search) && search!="")
                {
                    cn = int.Parse(search);
                }
                else
                {
                    cn = 0;
                }
                con.Open();


                string query = "Select * from Employees_data where employee_id=@search OR  firstname LIKE '%'+@search+'%' OR lastname LIKE '%'+@search+'%' OR CNIC=@search";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@cn", cn);

                SqlDataReader read = cmd.ExecuteReader();
                bool hasRows = read.HasRows;
                con.Close();
                if (hasRows)
                {
                    con.Open();
                    read.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    empTable.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        string fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        string lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        string d_id = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        string pass = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                        string cnic = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                        string email = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                        string dob = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                        string sal = ds.Tables[0].Rows[i].ItemArray[8].ToString();

                        string name = fname + " " + lname;
                        DataGridViewRow row1 = new DataGridViewRow();
                        row1.CreateCells(empTable);
                        row1.Cells[0].Value = id;
                        row1.Cells[1].Value = name;
                        row1.Cells[2].Value = d_id;
                        row1.Cells[3].Value = cnic;
                        row1.Cells[4].Value = email;
                        row1.Cells[5].Value = dob;
                        row1.Cells[6].Value = sal;


                        empTable.Rows.Add(row1);

                    }
                    con.Close();
                }

                else
                {
                empTable.Rows.Clear();
                }

            

        }
    }
}
