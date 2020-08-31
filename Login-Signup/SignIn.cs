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
    public partial class SignIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");

        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //-------------------------- Authenticate USer ------------------------------------------

            string selectQuery = "SELECT employee_id, user_password FROM Employees_data WHERE employee_id=@id AND user_password=@pas";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@id", empidField.Text);
            cmd.Parameters.AddWithValue("@pas", passwordField.Text);

            cmd.ExecuteNonQuery();
            SqlDataReader read = cmd.ExecuteReader();


            if (read.HasRows)
            {
                read.Read();

                //---- Sign In to Menu ----
                new nav().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unauthenticated Login Attempt !");

            }

            con.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userid_MouseHover(object sender, EventArgs e)
        {

        }
        

        private void userid_Click(object sender, EventArgs e)
        {

        }

        private void userid_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            signinButton.BackColor = System.Drawing.Color.Red;
            signinButton.ForeColor = System.Drawing.Color.White;
        }

        private void signinButton_MouseLeave(object sender, EventArgs e)
        {
            signinButton.BackColor = System.Drawing.Color.Indigo;
            signinButton.ForeColor = System.Drawing.Color.White;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.Red;
            exitButton.ForeColor = System.Drawing.Color.White;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.Indigo;
            exitButton.ForeColor = System.Drawing.Color.White;
        }
    }
}
