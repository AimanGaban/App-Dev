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
    public partial class Inventory_Form : Form 
    {
        private DataText medication_list;

        public void AddItems1(string mediID,string mediname, string unitofmeasure, string orderlevel, string unitcost, string unitprice, string balance, string newbalance, string details, string batchnumber , string expirydate, string checkedby)
        {

            //array to replace row
            string[] row = { mediID, mediname, unitofmeasure, orderlevel, unitcost, unitprice,  balance, newbalance, details, batchnumber, expirydate, checkedby };
            ListViewItem item = new ListViewItem(row);
            // add items
            listView.Items.Add(item);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            // add columns medication list
            listView.Columns.Add("Medication Id", 200);
            listView.Columns.Add("Medicine Name", 200);
            listView.Columns.Add("Unit Of Measure", 40);
            listView.Columns.Add("Order Level", 40);
            listView.Columns.Add("Unit Cost", 40);
            listView.Columns.Add("Unit Price", 40);
            listView.Columns.Add("Quantity available", 40);
            listView.Columns.Add("New Balance", 40);
            listView.Columns.Add("Details", 250);
            listView.Columns.Add("Batch Number", 40);
            listView.Columns.Add("Expiry Date", 40);
            listView.Columns.Add("Checked by", 40);
            // medication and charges
            combo.Items.Add("M01");// acne & sun damage medicine
            combo.Items.Add("M03");//improve skin and color
            combo.Items.Add("M02");////dark spot treatment
            
        }
        public Inventory_Form()
        {
            InitializeComponent();
            medication_list = new DataText();
            medication_list.Path = "C:/Users/User/Documents/STH THAT YOU SHUD BE DOIN/SEM 4/application development/group project/medication.txt";
            label15.Visible = false;
            button1.Visible = false;
            
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // to enable certain elements to be visible and invisible after button1 is clicked
            label2.Visible = true;
            label3.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Visible = false;
            textBox1.Visible = false;
            combo2.Visible = true;

            //prescription for every medicine
            //comboBox3.Items.Clear();
            if (combo.SelectedItem == "M01")
            {
                textBox2.Text = "Tretinoin";
                textBox3.Text = "10";
                textBox4.Text = "100";
                textBox5.Text = "2";
                textBox6.Text = "5";
                textBox8.Text = "30";
                textBox9.Text = "130";
                textBox10.Text = "acne & sun damage medicine";
                textBox11.Text = "04";
                textBox12.Text = "30 June 2023";
                // the admin list 
                combo2.Items.Add("Hafizi (01)");
                combo2.Items.Add("Rachel (02)");

            }
            else if (combo.SelectedItem == "M03")
            {
                textBox2.Text = "Beta-hydroxy acid (salicylic acid)";
                textBox3.Text = "50";
                textBox4.Text = "100";
                textBox5.Text = "60";
                textBox6.Text = "90";
                textBox8.Text = "30";
                textBox9.Text = "130";
                textBox10.Text = "improve skin and color";
                textBox11.Text = "05";
                textBox12.Text = "6 May 2022";
                // the admin list 
                combo2.Items.Add("Hafizi (01)");
                combo2.Items.Add("Rachel (02)");
            }
            else if (combo.SelectedItem == "M02")
            {
                textBox2.Text = "Hydroquinone";
                textBox3.Text = "15";
                textBox4.Text = "110";
                textBox5.Text = "65";
                textBox6.Text = "90";
                textBox8.Text = "20";
                textBox9.Text = "130";
                textBox10.Text = "dark spot treatment";
                textBox11.Text = "03";
                textBox12.Text = "13 March 2024";
                // the admin list 
                combo2.Items.Add("Hafizi (01)");
                combo2.Items.Add("Rachel (02)");
            }
            else
            {
                MessageBox.Show("ENTER DETAILS ");
                // the admin list 
                combo2.Items.Add("Hafizi (01)");
                combo2.Items.Add("Rachel (02)");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int unitofmeasure, orderlevel, unitcost, unitprice, balance, newbalance, batchnumber;
         
            //exception handling of the data inserted 
            bool isValid1 = int.TryParse(textBox3.Text, out unitofmeasure);

            if (!isValid1 || unitofmeasure < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the unit of measure");
                textBox3.Focus();
                return;
            }

            bool isValid2 = int.TryParse(textBox4.Text, out orderlevel);

            if (!isValid2 || orderlevel < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the order level");
                textBox4.Focus();
                return;
            }

            bool isValid3 = int.TryParse(textBox5.Text, out unitcost);

            if (!isValid3 || unitcost < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the unit cost");
                textBox5.Focus();
                return;
            }

            bool isValid4 = int.TryParse(textBox6.Text, out unitprice);

            if (!isValid4 || unitprice < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the unit price");
                textBox6.Focus();
                return;
            }

            bool isValid5 = int.TryParse(textBox8.Text, out balance);

            if (!isValid5 || balance < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the balance");
                textBox8.Focus();
                return;
            }

            bool isValid6 = int.TryParse(textBox4.Text, out newbalance);

            if (!isValid6 || newbalance < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in as the new balance");
                textBox4.Focus();
                return;
            }

            bool isValid7 = int.TryParse(textBox11.Text, out batchnumber);

            if (!isValid7 || batchnumber < 0)
            {
                MessageBox.Show("Invalid input! Please enter a valid positive integer in the batch number");
                textBox11.Focus();
                return;
            }


            //converting integer to string 
            unitofmeasure = int.Parse(textBox3.Text);

            orderlevel = int.Parse(textBox4.Text);

            unitcost = int.Parse(textBox5.Text);

            unitprice = int.Parse(textBox6.Text);

            balance = int.Parse(textBox8.Text);

            newbalance = int.Parse(textBox9.Text);

            batchnumber = int.Parse(textBox11.Text);
            AddItems1((string)combo.SelectedItem, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, (string)combo2.SelectedItem);
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = Visible;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox1.Clear();
            label1.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label7.Visible = false;
            label15.Visible = true;
            label16.Visible = true;
            label7.Visible = false;
            button1.Visible = false;
            combo.Visible = false;
            label14.Visible = false;
            combo2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            combo.Items.Add(textBox1.Text);
            combo.Visible = true;
            button1.Visible = true;
            textBox1.Visible = false;
            label7.Text = textBox1.Text;
            label1.Visible = false;
            label14.Visible = true;
            button5.Visible = false;
            button3.Visible = false;
            button2.Visible = true;

        }

        private void label15_Click(object sender, EventArgs e)
        {
           
            label1.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label7.Visible = false;
            label15.Visible = true;
            label16.Visible = true;
            label7.Visible = false;
            button1.Visible = false;
            combo.Visible = false;
            label14.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            combo.Visible = true;
            button1.Visible = true;
            textBox1.Visible = false;
            label1.Visible = false;
            label14.Visible = true;
            button5.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label7.Visible = false;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Main_Page MP = new Main_Page();
            this.Hide();
            MP.ShowDialog();
        }
    }
}
