using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SweetTea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "au_daar" && txtpassword.Text == "Energy1")
            {
                new SweetTea().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or Password you entered is Incorrect. Please try again.");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
