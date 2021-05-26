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

namespace RegistrationForm
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
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
        private void button1_Click(object sender, EventArgs e)
        {

            string fullname, address1, address2, address3, city, gender, email;
            double nric, postcode, contact;
            gender = null;
            fullname = textBox1.Text;
            nric = double.Parse(textBox2.Text);
            
            address1 = textBox3.Text;
            address2 = textBox4.Text;
            address3 = textBox5.Text;
            city = textBox6.Text;
            postcode = double.Parse(textBox7.Text);
            string state = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            contact = double.Parse(textBox8.Text);
            email = textBox9.Text;

            if(radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
                
            MessageBox.Show("New Patient Registered!" +
                "\n\nFull Name : " + fullname +
                "\nNRIC : " + nric.ToString() +
                "\nAddress : " + address1 + "\n\t " + address2 + "\n\t " + address3 +
                "\n\t " + city + " " + postcode.ToString() + ", " + state +
                "\nContact No. : " + contact.ToString() +
                "\nGender : " + gender +
                "\nEmail : " + email);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit information",
            "Mangga Aesthetic Clinic Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                MessageBox.Show("Confirm");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if(textBox6.Text == "City")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {

            if (textBox6.Text == "")
            {
                textBox6.Text = "City";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Postal Code")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Postal Code";
                textBox7.ForeColor = Color.Silver;
            }
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "name@example.com")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "name@example.com";
                textBox9.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "State")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "State";
                comboBox1.ForeColor = Color.Silver;
            }
        }
    }
}
