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
    public partial class addproduct : Form

    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");
        public addproduct()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new nav().Show();
            this.Hide();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pidField.Text = "";
        }

        private void gstField_Click(object sender, EventArgs e)
        {
            gstField.Text = "";
        }

        private void pnameField_Click(object sender, EventArgs e)
        {
            pnameField.Text = "";
        }

        private void cpriceField_Click(object sender, EventArgs e)
        {
            cpriceField.Text = "";
        }

        private void spriceField_Click(object sender, EventArgs e)
        {
            spriceField.Text = "";
        }

        private void promonameField_Click(object sender, EventArgs e)
        {
            promonameField.Text = "";
        }

        private void promoField_Click(object sender, EventArgs e)
        {
            promoField.Text = "";
        }

        private void addpButton_Click(object sender, EventArgs e)
        {
            add_in_database();
            
        }
        private void add_in_database()
        {
            con.Open();

            string prim = "SELECT * FROM Products WHERE product_id = @id";
            SqlCommand cmd2 = new SqlCommand(prim, con);
            cmd2.Parameters.AddWithValue("@id", pidField.Text);

            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;
            con.Close();

            if (flag)
            {
                MessageBox.Show("Already Product with this ID !");
            }
            else {
                con.Open();
            string insert_query = "INSERT INTO Products(product_id, product_name, cost_price, sale_price, GST, promotion_name, promotion) " +
                "VALUES (@id, @name, @cprice, @sprice, @gst, @pname, @promo)";
            SqlCommand cmd = new SqlCommand(insert_query, con);

            cmd.Parameters.AddWithValue("@id", pidField.Text );
            cmd.Parameters.AddWithValue("@name", pnameField.Text);
            cmd.Parameters.AddWithValue("@cprice", cpriceField.Text);
            cmd.Parameters.AddWithValue("@sprice", spriceField.Text);
            cmd.Parameters.AddWithValue("@gst", gstField.Text);
            cmd.Parameters.AddWithValue("@pname", promonameField.Text);
            cmd.Parameters.AddWithValue("@promo", promoField.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added Product");

            con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void updatepButton_MouseEnter(object sender, EventArgs e)
        {
            updatepButton.BackColor = System.Drawing.Color.Orange;
            updatepButton.ForeColor = System.Drawing.Color.Black;
        }

        private void updatepButton_MouseLeave(object sender, EventArgs e)
        {
            updatepButton.BackColor = System.Drawing.Color.HotPink;
            updatepButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void addpButton_MouseEnter(object sender, EventArgs e)
        {
            addpButton.BackColor = System.Drawing.Color.Orange;
            addpButton.ForeColor = System.Drawing.Color.Black;
        }

        private void addpButton_MouseLeave(object sender, EventArgs e)
        {
            addpButton.BackColor = System.Drawing.Color.HotPink;
            addpButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void menuButton_MouseClick(object sender, MouseEventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Orange;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Orange;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.HotPink;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {

            con.Open();
            string prim = "SELECT * FROM Products WHERE product_id = @id";
            SqlCommand cmd2 = new SqlCommand(prim, con);
            cmd2.Parameters.AddWithValue("@id", pidField.Text);

            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;
            con.Close();


            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Product ? ", "Delete Product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    con.Open();
                    string query = "delete from Products where product_id = @id";
                    SqlCommand cmd3 = new SqlCommand(query, con);
                    cmd3.Parameters.AddWithValue("@id", pidField.Text);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted Product ! ");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("The Product doesn't exist -_-");
            }
        }
    }
}
