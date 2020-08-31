using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class nav : Form
    {
        public nav()
        {
            InitializeComponent();
        }

        private void viewempButton_Click(object sender, EventArgs e)
        {
            new employees().Show();
            this.Close();
        }

        private void viewproductsButton_Click(object sender, EventArgs e)
        {
            new products().Show();
            this.Close();
        }

        private void newsaleButton_Click(object sender, EventArgs e)
        {
            new newsale().Show();
            this.Close();
        }

        private void addproductButton_Click(object sender, EventArgs e)
        {
            new addproduct().Show();
            this.Close();
        }

        private void newsaleButton_MouseEnter(object sender, EventArgs e)
        {
            newsaleButton.BackColor = System.Drawing.Color.Azure;
            newsaleButton.ForeColor = System.Drawing.Color.Black;
        }

        private void newsaleButton_MouseLeave(object sender, EventArgs e)
        {
            newsaleButton.BackColor = System.Drawing.Color.Teal;
            newsaleButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void viewdepButton_MouseEnter(object sender, EventArgs e)
        {
            viewdepButton.BackColor = System.Drawing.Color.Azure;
            viewdepButton.ForeColor = System.Drawing.Color.Black;
        }

        private void viewdepButton_MouseLeave(object sender, EventArgs e)
        {
            viewdepButton.BackColor = System.Drawing.Color.Teal;
            viewdepButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void viewproButton_MouseEnter(object sender, EventArgs e)
        {
            viewproButton.BackColor = System.Drawing.Color.Azure;
            viewproButton.ForeColor = System.Drawing.Color.Black;
        }

        private void viewproButton_MouseLeave(object sender, EventArgs e)
        {
            viewproButton.BackColor = System.Drawing.Color.Tomato;
            viewproButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void addproButton_MouseEnter(object sender, EventArgs e)
        {
            addproButton.BackColor = System.Drawing.Color.Azure;
            addproButton.ForeColor = System.Drawing.Color.Black;
        }

        private void addproButton_MouseLeave(object sender, EventArgs e)
        {
            addproButton.BackColor = System.Drawing.Color.Tomato;
            addproButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void updateempButton_Click(object sender, EventArgs e)
        {
            new AddEmp().Show();
            this.Close();
        }

        private void updateempButton_MouseEnter(object sender, EventArgs e)
        {
            updateempButton.BackColor = System.Drawing.Color.Tomato;
            updateempButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void updateempButton_MouseLeave(object sender, EventArgs e)
        {
            updateempButton.BackColor = System.Drawing.Color.MistyRose;
            updateempButton.ForeColor = System.Drawing.Color.Black;
        }

        private void viewempButton_MouseEnter(object sender, EventArgs e)
        {
            viewempButton.BackColor = System.Drawing.Color.Tomato;
            viewempButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void viewempButton_MouseLeave(object sender, EventArgs e)
        {
            viewempButton.BackColor = System.Drawing.Color.MistyRose;
            viewempButton.ForeColor = System.Drawing.Color.Black;
        }

        private void viewdepButton_Click(object sender, EventArgs e)
        {
            new Departments().Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.Teal;
            exitButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = System.Drawing.Color.MistyRose;
            exitButton.ForeColor = System.Drawing.Color.Black;
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.BackColor = System.Drawing.Color.Teal;
            logoutButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackColor = System.Drawing.Color.MistyRose;
            logoutButton.ForeColor = System.Drawing.Color.Black;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Close();
        }
    }
}
