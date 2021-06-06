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
        //To show about and credit
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String About = "Clinic Management System\nCreated for Klinik Mangga\n\nCreated by Faie, Jeeha, Nayli, Anis, and Gaban", AboutTitle = "About";
            MessageBox.Show(About,AboutTitle);
        }
        //Close application. Refer to Login Page.cs for explanation
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //To access the client and registration
        private void ClientButton_Click(object sender, EventArgs e)
        {
            PatientRegistration PR = new PatientRegistration();
            this.Hide();
            PR.ShowDialog();
        }
        //To access the appointment form
        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment_Form AP = new Appointment_Form();
            this.Hide();
            AP.ShowDialog();
        }
        //To access the inventory
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory_Form IF = new Inventory_Form();
            this.Hide();
            IF.ShowDialog();
        }
        //To access the medication and medicine details for patient
        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Medication_Form MF = new Medication_Form();
            this.Hide();
            MF.ShowDialog();
        }
        //To access the billing and payment
        private void BillingButton_Click(object sender, EventArgs e)
        {
            Billing_Form BF = new Billing_Form();
            this.Hide();
            BF.ShowDialog();
        }
        //To log out and go back to login page
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login_Page LP = new Login_Page();
            this.Hide();
            LP.Show();
        }
    }
}
