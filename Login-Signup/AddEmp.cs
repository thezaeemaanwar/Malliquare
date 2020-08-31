///*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class AddEmp : Form

    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAmwar;Initial Catalog=TheShoppingMall;Integrated Security=True");

        public AddEmp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (passwordField.Text == cpasswordField.Text)
            {
                save_data_in_database();
                firstnameField.Text = "";
                lastnameField.Text = "";
                empidField.Text = "";
                emailField.Text = "";
                cnicField.Text = "";
                passwordField.Text = "";
                cpasswordField.Text = "";
                departmentField.Text = "";
                salaryField.Text = "";
            }
            else
                MessageBox.Show("Passwords don't match ! ");
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void empidField2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }
        private void save_data_in_database()
        {

            con.Open();

            // If The Entered Id is already present in Table

            string prim = "SELECT * FROM Employees_data WHERE employee_id = @id";
            SqlCommand cmd2 = new SqlCommand(prim, con);
            cmd2.Parameters.AddWithValue("@id", empidField.Text);

            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows; 
            
            con.Close();
            
            if (flag)
            {
                MessageBox.Show("Already an Employee with this ID !");
            }

            // If ID is not present , Sava Data Successfully
            else
            {
                
                string dep = departmentField.Text;

                if (string.Equals(dep, "Management"))
                    dep = "MAN";
                else if (string.Equals(dep, "Accounts"))
                    dep = "ACC";
                else if (string.Equals(dep, "Sales"))
                    dep = "SAL";
                else if (string.Equals(dep, "Purchase"))
                    dep = "PUR";


                int salary = int.Parse(salaryField.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));
                
                string insert_in_emp = "insert into Employees_data(employee_id, firstname, lastname, user_password, " +
                                        "CNIC, email, DOB, department_id, salary) " +
                                        "values(@id, @fname, @lname , @pass, @cnic, @mail, @dob, @dep_id, @sal)";

                con.Open();
                SqlCommand cmd = new SqlCommand(insert_in_emp, con);

                cmd.Parameters.AddWithValue("@id", empidField.Text);
                cmd.Parameters.AddWithValue("@fname", firstnameField.Text);
                cmd.Parameters.AddWithValue("@lname", lastnameField.Text);
                cmd.Parameters.AddWithValue("@pass", passwordField.Text);
                cmd.Parameters.AddWithValue("@cnic", cnicField.Text);
                cmd.Parameters.AddWithValue("@mail", emailField.Text);
                cmd.Parameters.AddWithValue("@dob", dobField.Text);
                cmd.Parameters.AddWithValue("@dep_id", dep);
                cmd.Parameters.AddWithValue("@sal", salary);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee is successfully added!");
            }


        }

        private void populate_data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees_data");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset); 

            for (int i=0 ; i<dataset.Tables[0].Rows.Count ; i++)
            {
                String id = dataset.Tables[0].Rows[1].ItemArray[0].ToString();
                String fname = dataset.Tables[0].Rows[1].ItemArray[1].ToString();
                String lname = dataset.Tables[0].Rows[1].ItemArray[2].ToString();
                String pas = dataset.Tables[0].Rows[1].ItemArray[3].ToString();
                String cnic = dataset.Tables[0].Rows[1].ItemArray[4].ToString();
                String email = dataset.Tables[0].Rows[1].ItemArray[5].ToString();
                String dob = dataset.Tables[0].Rows[1].ItemArray[6].ToString();
                DataGridViewRow viewRow = new DataGridViewRow();
                //viewRow.CreateCells(empTable);

            }

            con.Close();
        }

        private void addempButton_MouseEnter(object sender, EventArgs e)
        {
            addempButton.BackColor = System.Drawing.Color.White;
            addempButton.ForeColor = System.Drawing.Color.Black;
        }

        private void addempButton_MouseLeave(object sender, EventArgs e)
        {
            addempButton.BackColor = System.Drawing.Color.Indigo;
            addempButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void cnicField_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryField_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new nav().Show();
            this.Hide();
        }

        private void updateButton_MouseEnter(object sender, EventArgs e)
        {
            updateButton.BackColor = System.Drawing.Color.White;
            updateButton.ForeColor = System.Drawing.Color.Black;
        }

        private void updateButton_MouseLeave(object sender, EventArgs e)
        {
            updateButton.BackColor = System.Drawing.Color.Indigo;
            updateButton.ForeColor = System.Drawing.Color.GhostWhite;

        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.White;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Indigo;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void AddEmp_MouseEnter(object sender, EventArgs e)
        {
        //    updateempButton.BackColor = System.Drawing.Color.Tomato;
          //  addEmpButton.ForeColor = System.Drawing.Color.White;
        }

        private void departmentField_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.Equals("Management", departmentField.Text) || string.Equals("Sales", departmentField.Text) || string.Equals("Accounts", departmentField.Text) || string.Equals("Purchase", departmentField.Text))
            {
                departmentField.BackColor = System.Drawing.Color.BlanchedAlmond;
                departmentField.ForeColor = System.Drawing.Color.Indigo;
            }
            else
            {
                departmentField.BackColor = System.Drawing.Color.Red;
                departmentField.ForeColor = System.Drawing.Color.Wheat;
            }
                
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            con.Open();

            string prim = "SELECT * FROM Employees_data WHERE employee_id = @id";
            SqlCommand cmd2 = new SqlCommand(prim, con);
            cmd2.Parameters.AddWithValue("@id", empidField.Text);

            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;
            con.Close();

            // If employee with the id is not present
            if (!flag)
            {
                MessageBox.Show("No employee with this ID !");
            }

            // If ID is present , Update Data Successfully
            else
            {
                string eid = empidField.Text;
                string dep = departmentField.Text;
                string fname = firstnameField.Text;
                string lname = lastnameField.Text;
                string email = emailField.Text;
                string password = passwordField.Text;
                string sal = salaryField.Text;
                int count = 0;
                if (dep != "")
                {
                    if (string.Equals(dep, "Management"))
                        dep = "MAN";
                    else if (string.Equals(dep, "Accounts"))
                        dep = "ACC";
                    else if (string.Equals(dep, "Sales"))
                        dep = "SAL";
                    else if (string.Equals(dep, "Purchase"))
                        dep = "PUR";

                    
                    string query = "UPDATE Employees_data SET department_id = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", dep);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;
                }
                if (fname != "")
                {
                    string query = "UPDATE Employees_data SET firstname = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", fname);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;
                }
                if (lname != "")
                {
                    string query = "UPDATE Employees_data SET lastname = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", lname);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;
                }
                if (email != "")
                {
                    string query = "UPDATE Employees_data SET email = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", email);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;
                }
                if (password != "")
                {
                    string query = "UPDATE Employees_data SET user_password = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", password);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;

                }
                if (sal != "")
                {
                    string query = "UPDATE Employees_data SET salary = @dep_id where employee_id = @id";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@dep_id", sal);
                    cmd1.Parameters.AddWithValue("@id", eid);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    count++;

                }

                if (count > 0)
                {
                    MessageBox.Show("Employee Updated Successfully ! ");
                }
                else
                    MessageBox.Show("Nothing to update ! ");
                
            }

        }

        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string prim = "SELECT * FROM Employees_data WHERE employee_id = @id";
            SqlCommand cmd2 = new SqlCommand(prim, con);
            cmd2.Parameters.AddWithValue("@id", empidField.Text);

            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;
            con.Close();


            if (flag) { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee ? ", "Delete Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    con.Open();
                    string query = "delete from Employees_data where employee_id = @id";
                    SqlCommand cmd3 = new SqlCommand(query, con);
                    cmd3.Parameters.AddWithValue("@id", empidField.Text);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted Employee ! ");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("The Employee doesn't exist -_-");
            }
        }
    }
}

//*/