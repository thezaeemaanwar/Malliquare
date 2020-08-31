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
    public partial class newsale : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");
        int Total_bill =0;
        public newsale()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            billButton.Text = Total_bill.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new nav().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nsaleButton_Click(object sender, EventArgs e)
        {
            con.Open();


            string insert_query = "INSERT INTO sales(sale_date,cash_recieved, bill) " +
                "VALUES (@date,@cash, @bill)";
            string date_query = "SELECT getdate()";

            SqlCommand cmd_date = new SqlCommand(date_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd_date);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            string date = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            SqlCommand cmd = new SqlCommand(insert_query, con);

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@cash", recField.Text);
            cmd.Parameters.AddWithValue("@bill", billButton.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesful Sale :) ");

            con.Close();
            this.Close();
            new newsale().Show();
        }

        private void pid2Field_TextChanged(object sender, EventArgs e)
        {
            pidField.ForeColor = System.Drawing.Color.Black;
        }

        private void qty2Field_TextChanged(object sender, EventArgs e)
        {
            qtyField.ForeColor = System.Drawing.Color.Black;
        }

        private void recField_TextChanged(object sender, EventArgs e)
        {
            //recField.Text = "";
        }

        private void retField_TextChanged(object sender, EventArgs e)
        {
           // retField.Text = "";
        }

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {
            enterButton.BackColor = System.Drawing.Color.FloralWhite;
            enterButton.ForeColor = System.Drawing.Color.Maroon;
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = System.Drawing.Color.Maroon;
            enterButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void nsaleButton_MouseEnter(object sender, EventArgs e)
        {
            nsaleButton.BackColor = System.Drawing.Color.FloralWhite;
            nsaleButton.ForeColor = System.Drawing.Color.Maroon;
        }

        private void nsaleButton_MouseLeave(object sender, EventArgs e)
        {
            nsaleButton.BackColor = System.Drawing.Color.Maroon;
            nsaleButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.FloralWhite;
            exitButton.ForeColor = System.Drawing.Color.Maroon;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.Maroon;
            exitButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.FloralWhite;
            menuButton.ForeColor = System.Drawing.Color.Maroon;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Maroon;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void pid2Field_Click(object sender, EventArgs e)
        {
            pidField.Text = "";
        }

        private void qty2Field_Click(object sender, EventArgs e)
        {
            qtyField.Text = "";
        }
        private void search()
        {
            if (IsDigitsOnly(qtyField.Text))
            {
                con.Open();
                string selectQuery = "SELECT product_id,product_name,GST,sale_price FROM Products WHERE product_id=@id ";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@id", pidField.Text);
                //cmd.Parameters.AddWithValue("@pas", qtyField.Text);

                cmd.ExecuteNonQuery();

                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    string qty = qtyField.Text;
                    read.Close();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    adapter2.Fill(ds2);

                    string id = ds2.Tables[0].Rows[0].ItemArray[0].ToString();
                    string name = ds2.Tables[0].Rows[0].ItemArray[1].ToString();
                    string gst = ds2.Tables[0].Rows[0].ItemArray[2].ToString();
                    string sprice = ds2.Tables[0].Rows[0].ItemArray[3].ToString();
                    
                    int total = int.Parse(sprice) * int.Parse(qty);

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(billTable);
                    row1.Cells[0].Value = id;
                    row1.Cells[1].Value = name;
                    row1.Cells[2].Value = gst;
                    row1.Cells[3].Value = sprice;
                    row1.Cells[4].Value = qty;
                    row1.Cells[5].Value = total;

                    Total_bill = Total_bill+total;
                    billTable.Rows.Add(row1);
                    billButton.Text = Total_bill.ToString();
                }
                else
                    MessageBox.Show("No Product with this ID !");

                con.Close();
            }
            else
            {
                MessageBox.Show("Enter numbers Only");
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

        private void recField_Click(object sender, EventArgs e)
        {
            recField.Text = "";
        }

        private void recField_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void recField_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void retField_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void retButton_Click(object sender, EventArgs e)
        {
            if (string.Equals(billButton.Text, "") && string.Equals(recField.Text, ""))
            {
                MessageBox.Show("Enter all Fields !");
            }
            else{
                //int a = int.Parse(billField.Text);
                //int b = int.Parse(recField.Text);
                //int ret = b - a;
                retButton.Text = (int.Parse(recField.Text) - int.Parse(billButton.Text)).ToString();
            }
        }

        private void newsale_Load(object sender, EventArgs e)
        {

        }

        private void billButton_Click(object sender, EventArgs e)
        {
            
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new newsale().Show();
        }
    }
}
