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

            //set ListView properties
            listView1.View = View.Details;
            
            //construct columns
            listView1.Columns.Add("NRIC", 90);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Address", 200);
            listView1.Columns.Add("Postcode City", 70);
            listView1.Columns.Add("State", 80);
            listView1.Columns.Add("Contact No.", 90);
            listView1.Columns.Add("Gender", 60);
            listView1.Columns.Add("Email", 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Patient Registration Application Form";
            this.Location = new Point(450, 200);
            this.MaximizeBox = false;
            MessageBox.Show("Note: You may required to fill out this registration form",
            "Klinik Mangga Aesthetic Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            cmbstate.Items.Add("Johor");
            cmbstate.Items.Add("Kedah");
            cmbstate.Items.Add("Kelantan");
            cmbstate.Items.Add("Melaka");
            cmbstate.Items.Add("Negeri Sembilan");
            cmbstate.Items.Add("Pahang");
            cmbstate.Items.Add("Pulau Pinang");
            cmbstate.Items.Add("Perak");
            cmbstate.Items.Add("Perlis");
            cmbstate.Items.Add("Selangor");
            cmbstate.Items.Add("Terengganu");
            cmbstate.Items.Add("Sabah");
            cmbstate.Items.Add("Sarawak");
            cmbstate.Items.Add("Wilayah Persekutuan");

        }

        //add row
        private void save(String nric, String name, String add, String postcode, 
            String state, String contact, String gender, String email)
        {
            //array to rep a row
            String[] row = { nric, name, add, postcode, state, contact, gender, email };

            ListViewItem item = new ListViewItem(row);

            //add to ListView
            listView1.Items.Add(item);
        }

        //getGender selected item
        private String getGender()
        {
            if(rbmale.Checked)
            {
                return "Male";
            }
            else if(rbfemale.Checked)
            {
                return "Female";
            }
            return "None";
        }
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            save(txtnric.Text, txtname.Text, txtadd.Text, txtcitycode.Text, 
                cmbstate.SelectedItem.ToString(), txtcontact.Text, getGender(), txtemail.Text);
            //clear txt
            txtnric.Text = "";
            txtname.Text = "";
            txtadd.Text = "";
            txtcitycode.Text = "";
            cmbstate.SelectedItem = "";
            txtcontact.Text = "";
            txtemail.Text = "";
        }
        
        //edit or update
        private void edit()
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtnric.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtname.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtadd.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtcitycode.Text;
            listView1.SelectedItems[0].SubItems[4].Text = cmbstate.Text;
            listView1.SelectedItems[0].SubItems[5].Text = txtcontact.Text;
            listView1.SelectedItems[0].SubItems[4].Text = rbmale.Text;
            listView1.SelectedItems[0].SubItems[6].Text = txtemail.Text;

            //clear txt
            txtnric.Text = "";
            txtname.Text = "";
            txtadd.Text = "";
            txtcitycode.Text = "";
            cmbstate.SelectedItem = "";
            txtcontact.Text = "";
            txtemail.Text = "";
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit/ Update information",
            "Klinik Mangga Aesthetic Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            edit();
        }

        //delete
        private void delete()
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                //clear txt
                txtnric.Text = "";
                txtname.Text = "";
                txtadd.Text = "";
                txtcitycode.Text = "";
                cmbstate.SelectedItem = "";
                txtcontact.Text = "";
                txtemail.Text = "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm if you want to leave the page", "Close page", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtnric.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtadd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtcitycode.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cmbstate.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtcontact.Text = listView1.SelectedItems[0].SubItems[5].Text;
            rbmale.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtemail.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void txtcitycode_Enter(object sender, EventArgs e)
        {
            if (txtcitycode.Text == "Postcode City")
            {
                txtcitycode.Text = "";
                txtcitycode.ForeColor = Color.Black;
            }
        }
        private void txtcitycode_Leave(object sender, EventArgs e)
        {
            if (txtcitycode.Text == "")
            {
                txtcitycode.Text = "Postcode City";
                txtcitycode.ForeColor = Color.Silver;
            }
        }


        private void cmbstate_Enter(object sender, EventArgs e)
        {
            if (cmbstate.Text == "State")
            {
                cmbstate.Text = "";
                cmbstate.ForeColor = Color.Black;
            }
        }

        private void cmbstate_Leave(object sender, EventArgs e)
        {
            if (cmbstate.Text == "")
            {
                cmbstate.Text = "State";
                cmbstate.ForeColor = Color.Silver;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "someone@example.com")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "someone@example.com";
                txtemail.ForeColor = Color.Silver;
            }
        }
    }
}
