using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicationform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //service type
            surgeryRB.Checked = true; // surgery radio button
            TreatmentRB.Checked = true; // treatment radio button

            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.Value = DateTime.Today;

            // medication and charges
            comboBox2.Items.Add("Tretinoin");// acne & sun damage medicine
            comboBox2.Items.Add("Beta-hydroxy acid (salicylic acid)");//improve skin and color
            comboBox2.Items.Add("Hydroquinone");////dark spot treatment

            //list view
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            
           
        }

       

        // add rows
        public void AddItems(string mediName, string Prescription, string Quantity, string Notes)
        {

            //array to replace row

            string[] row = { mediName, Prescription, Quantity, Notes };
            ListViewItem item = new ListViewItem(row);

            // add items
            listView1.Items.Add(item);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prescription for every medicine
            comboBox3.Items.Clear();
            if (comboBox2.SelectedItem == "Tretinoin")
            {
                comboBox3.Items.Add("1 tablets x 7 days");
                comboBox3.Items.Add("1 tablets x 14 days");
                comboBox3.Items.Add("1 tablets x 28 days");
            }
            else if (comboBox2.SelectedItem == "Beta-hydroxy acid (salicylic acid)")
            {
                comboBox3.Items.Add("1 times per day");
                comboBox3.Items.Add("2 times per day");
                comboBox3.Items.Add("1 time per week");
            }
            else if (comboBox2.SelectedItem == "Hydroquinone")
            {
                comboBox3.Items.Add("1 times per day");
                comboBox3.Items.Add("2 times per day");
                comboBox3.Items.Add("1 time per week");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // items add in listview
            AddItems((string)comboBox2.SelectedItem, (string)comboBox3.SelectedItem, textBox3.Text, textBox5.Text);

        }
        private void removeItem()
        {
            if(MessageBox.Show("Are you sure?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeItem();

        }
        

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string mediName = listView1.SelectedItems[0].SubItems[0].Text;
            string Prescription = listView1.SelectedItems[0].SubItems[1].Text;
            string Quantity = listView1.SelectedItems[0].SubItems[2].Text;
            string Notes = listView1.SelectedItems[0].SubItems[3].Text;

            comboBox2.SelectedItem = mediName;
            comboBox3.SelectedItem = Prescription;
            textBox3.Text = Quantity;
            textBox5.Text = Notes;
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
       
        private void button3_Click(object sender, EventArgs e)
        {
            string[] patient;
            patient = new string[1];
            for (int i = 0; i < patient.Length; i++)
            {
                patient[i] = textBox1.Text;
                string message = "Do you want to save " + patient[i] + "'s Prescription?";
                string title = "Save Patient Prescription";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show( patient[i] + "'s Prescription has been saved!");
                }
                else
                {
                    this.Close();
                }
            }

            SetValueForText1 = textBox1.Text;//patient Name
            SetValueForText2 = textBox2.Text;//patient ID
            
            if(surgeryRB.Checked == true)
            {
                SetValueForText3 = surgeryRB.Text;//surgery
            }
            else if(TreatmentRB.Checked == true)
            {
                SetValueForText3 = TreatmentRB.Text;//treatment
            }
            SetValueForText4 = dateTimePicker1.Text;//date
            SetValueForText5 = (string)comboBox1.SelectedItem;//surgery/treatment Name
           
            
            Form2 Saveform = new Form2();
            Saveform.Show();
            
           



        }
        

        private void surgeryRB_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            // TYPE OF SURGERY
            if(surgeryRB.Checked == true)
            {
                comboBox1.Items.Add("Nose Jobs");
                comboBox1.Items.Add("Face Lifts");
                comboBox1.Items.Add("Tummy Tuck");
                comboBox1.Items.Add("Liposuction");
                comboBox1.Items.Add("Eyelfit");
                comboBox1.Items.Add("Rhinoplasty");
            }
            //TYPE OF TREATMENT
            else if (TreatmentRB.Checked == true)
            {
                comboBox1.Items.Add("Chemical Peel");
                comboBox1.Items.Add("Skin Laser and Restoration");
                comboBox1.Items.Add("Derma Filler");
                comboBox1.Items.Add("Pigmentation and Scar Reduction");
                comboBox1.Items.Add("Botox Injection");
                comboBox1.Items.Add("Dermabrasion");

            }
        }
    }
}
