//Bright Mohlala
//2025355740
//Practical 3
//29 July 2024
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        //create a click method to clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";//name text is null
            txtCompany.Text = "";//Company text is null
            txtPassword.Text = "";//Password text is null
        }
        //create a submit method to submit the input of the user
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //convert the texts to strings
            String sName = txtName.Text.ToString();
            String sCompany = txtCompany.Text.ToString();
            String sPassword = txtPassword.Text.ToString();
            //create an if statement to check if the user has provided all the required information
            if(txtName.Text != "" && txtCompany.Text != "" && txtPassword.Text != "")
            {
                //if the user has provided all the required information then display the welcome message below
                MessageBox.Show("Welcome " + txtName.Text + " from " + txtCompany.Text + "!", "Success");
            }
            else
            {
                //if the user didn't provided all the required information then display the error message below
                MessageBox.Show("Please complete all the fields before submitting.", "Error");
            }
        }
    }
}
