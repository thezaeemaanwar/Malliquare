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
    public partial class products : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");

        public products()
        {
            InitializeComponent();
            populateData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new nav().Show();
        }
        private void populateData()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            con.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            productTable.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string costprice = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string gst = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string saleprice = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string promoName = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string promo = ds.Tables[0].Rows[i].ItemArray[6].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(productTable);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = costprice;
                row1.Cells[3].Value = saleprice;
                row1.Cells[4].Value = gst;
                row1.Cells[5].Value = promoName;
                row1.Cells[6].Value = promo;


                productTable.Rows.Add(row1);
            }

            //con.Close();
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {

            string search = searchproductField.Text;
            int cn;


            if (searchproductField.Text == "")
                MessageBox.Show("Can't read your Mind thogh :/ ");
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

                string query = "Select * from Products where product_id=@search OR  product_name LIKE '%'+@search+'%' OR promotion_name=@search OR sale_price=@cn ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@cn", cn);

                SqlDataReader read2 = cmd.ExecuteReader();
                bool flag = read2.HasRows;
                read2.Close();
                con.Close();

                if (flag)
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    adapter2.Fill(ds2);
                    productTable.Rows.Clear();

                    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                    {
                        string id = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                        string name = ds2.Tables[0].Rows[i].ItemArray[1].ToString();
                        string costprice = ds2.Tables[0].Rows[i].ItemArray[2].ToString();
                        string gst = ds2.Tables[0].Rows[i].ItemArray[3].ToString();
                        string saleprice = ds2.Tables[0].Rows[i].ItemArray[4].ToString();
                        string promoName = ds2.Tables[0].Rows[i].ItemArray[5].ToString();
                        string promo = ds2.Tables[0].Rows[i].ItemArray[6].ToString();
                        DataGridViewRow row2 = new DataGridViewRow();
                        row2.CreateCells(productTable);
                        row2.Cells[0].Value = id;
                        row2.Cells[1].Value = name;
                        row2.Cells[2].Value = costprice;
                        row2.Cells[3].Value = saleprice;
                        row2.Cells[4].Value = gst;
                        row2.Cells[5].Value = promoName;
                        row2.Cells[6].Value = promo;


                        productTable.Rows.Add(row2);
                    }

                }
                else
                {
                    MessageBox.Show("No Such Product !");
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

        private void allproButton_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void searchproductField_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void searchproductField_KeyPress(object sender, KeyPressEventArgs e)
        {

            string search = searchproductField.Text;
            int cn;


            

                if (IsDigitsOnly(search) && search != "")
                {
                    cn = int.Parse(search);
                }
                else
                {
                    cn = 0;
                }

                con.Open();

                string query = "Select * from Products where product_id=@search OR  product_name LIKE '%'+@search+'%' OR promotion_name=@search OR sale_price=@cn ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@cn", cn);

                SqlDataReader read2 = cmd.ExecuteReader();
                bool flag = read2.HasRows;
                read2.Close();
                con.Close();

                if (flag)
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    adapter2.Fill(ds2);
                    productTable.Rows.Clear();

                    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                    {
                        string id = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                        string name = ds2.Tables[0].Rows[i].ItemArray[1].ToString();
                        string costprice = ds2.Tables[0].Rows[i].ItemArray[2].ToString();
                        string gst = ds2.Tables[0].Rows[i].ItemArray[3].ToString();
                        string saleprice = ds2.Tables[0].Rows[i].ItemArray[4].ToString();
                        string promoName = ds2.Tables[0].Rows[i].ItemArray[5].ToString();
                        string promo = ds2.Tables[0].Rows[i].ItemArray[6].ToString();
                        DataGridViewRow row2 = new DataGridViewRow();
                        row2.CreateCells(productTable);
                        row2.Cells[0].Value = id;
                        row2.Cells[1].Value = name;
                        row2.Cells[2].Value = costprice;
                        row2.Cells[3].Value = saleprice;
                        row2.Cells[4].Value = gst;
                        row2.Cells[5].Value = promoName;
                        row2.Cells[6].Value = promo;


                        productTable.Rows.Add(row2);
                    }

                }
                else
                {
                productTable.Rows.Clear();
                }

            


        }
    }
}
