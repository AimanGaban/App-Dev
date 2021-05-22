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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String About = "Clinic Management System\nCreated for Klinik Mangga\n\nCreated by Faie, Jeeha, Nayli, Anis, and Gaban", AboutTitle = "About";
            MessageBox.Show(About,AboutTitle);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {

        }

        private void BillingButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login_Page LP = new Login_Page();
            LP.Show();
            this.Close();
        }
    }
}
