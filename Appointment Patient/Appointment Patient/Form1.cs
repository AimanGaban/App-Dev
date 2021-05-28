using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Patient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_service.Items.Clear();
            cmb_service.Items.Add("Nose Jobs");
            cmb_service.Items.Add("Face Lifts");
            cmb_service.Items.Add("Tummy Tuck");
            cmb_service.Items.Add("Liposuction");
            cmb_service.Items.Add("Eyelift");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            cmb_service.Items.Clear();
            cmb_service.Items.Add("Chemical Peel");
            cmb_service.Items.Add("Skin Laser and Restoration");
            cmb_service.Items.Add("Dermal Filler");
            cmb_service.Items.Add("Pigmentation and Scar Reduction");
            cmb_service.Items.Add("Botox Injection"); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = txt_ic.Text;
            arr[1] = txt_name.Text;
            arr[2] = dtp_date.Text;
            arr[3] = cmb_service.SelectedItem.ToString();

            ListViewItem lst = new ListViewItem(arr);
            listView1.Items.Add(lst);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save this appointment?";
            string title = "Save Appointment";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Appointment has been saved!");
            }
            else
            {
                this.Close();
            }
        }
    }
}
