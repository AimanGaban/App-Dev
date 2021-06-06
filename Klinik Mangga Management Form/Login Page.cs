using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik_Mangga_Management_Form
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }
        //To activating the button's function and enable to enter user's input
        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Setting the password
            String user = "Admin", password = "123456";
            //Creating a conditional for entered details, if same, it will allow access
            if ((IDBox.Text == user) && (PasswordBox.Text == password))
            {
                MessageBox.Show("You have entered the correct password", "Welcome");
                this.Hide();
                Main_Page MP = new Main_Page();
                MP.ShowDialog();
            }
            //If the user entered the wrong password
            else
            {
                MessageBox.Show("Please re-enter the correct detail", "Wrong ID or Password");
            }
        }
        //Showing correct details for user (Will be deleted for future usage)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("ID: Admin\nPassword: 123456", "ID & Password");
        }
        /* Close application. To close the application, we are using Exit instead of Close
         * because it's more specific and will end the application in background.
         */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
