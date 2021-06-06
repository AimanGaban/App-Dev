using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Klinik_Mangga_Management_Form

{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
            RadioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            RadioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Patient Registration Application Form";
            this.Location = new Point(500, 200);
            this.MaximizeBox = false;
            MessageBox.Show("Note: You may required to fill out this registration form",
            "Mangga Aesthetic Clinic Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Main_Page MP = new Main_Page();
            string fullname, address1, address2, address3, city, gender, email;
            double nric, postcode, contact;
            gender = null;
            fullname = TextBox1.Text;
            nric = double.Parse(TextBox2.Text);
            
            address1 = TextBox3.Text;
            address2 = TextBox4.Text;
            address3 = TextBox5.Text;
            city = TextBox6.Text;
            postcode = double.Parse(TextBox7.Text);
            string state = this.ComboBox1.GetItemText(this.ComboBox1.SelectedItem);
            contact = double.Parse(TextBox8.Text);
            email = TextBox9.Text;

            if(RadioButton1.Checked == true)
            {
                gender = RadioButton1.Text;
            }
            else if(RadioButton2.Checked == true)
            {
                gender = RadioButton2.Text;
            }
                
            MessageBox.Show("New Patient Registered!" +
                "\n\nFull Name : " + fullname +
                "\nNRIC : " + nric.ToString() +
                "\nAddress : " + address1 + "\n\t " + address2 + "\n\t " + address3 +
                "\n\t " + city + " " + postcode.ToString() + ", " + state +
                "\nContact No. : " + contact.ToString() +
                "\nGender : " + gender +
                "\nEmail : " + email);
            MP.ShowDialog();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit information",
            "Mangga Aesthetic Clinic Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
            TextBox8.Clear();
            TextBox9.Clear();
            ComboBox1.Items.Clear();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
        }
        void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                MessageBox.Show("Confirm");
        }

        private void TextBox6_Enter(object sender, EventArgs e)
        {
            if(TextBox6.Text == "City")
            {
                TextBox6.Text = "";
                TextBox6.ForeColor = Color.Black;
            }
        }
        private void TextBox6_Leave(object sender, EventArgs e)
        {

            if (TextBox6.Text == "")
            {
                TextBox6.Text = "City";
                TextBox6.ForeColor = Color.Silver;
            }
        }

        private void TextBox7_Enter(object sender, EventArgs e)
        {
            if (TextBox7.Text == "Postal Code")
            {
                TextBox7.Text = "";
                TextBox7.ForeColor = Color.Black;
            }
        }

        private void TextBox7_Leave(object sender, EventArgs e)
        {
            if (TextBox7.Text == "")
            {
                TextBox7.Text = "Postal Code";
                TextBox7.ForeColor = Color.Silver;
            }
        }
        private void TextBox9_Enter(object sender, EventArgs e)
        {
            if (TextBox9.Text == "name@example.com")
            {
                TextBox9.Text = "";
                TextBox9.ForeColor = Color.Black;
            }
        }

        private void TextBox9_Leave(object sender, EventArgs e)
        {
            if (TextBox9.Text == "")
            {
                TextBox9.Text = "name@example.com";
                TextBox9.ForeColor = Color.Silver;
            }
        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "State")
            {
                ComboBox1.Text = "";
                ComboBox1.ForeColor = Color.Black;
            }
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "")
            {
                ComboBox1.Text = "State";
                ComboBox1.ForeColor = Color.Silver;
            }
        }
    }
}
