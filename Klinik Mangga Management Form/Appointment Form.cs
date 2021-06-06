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
    public partial class Appointment_Form : Form
    {
        public Appointment_Form()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = System.Drawing.Color.Green;
            RadioButton2.ForeColor = System.Drawing.Color.Red;

            Cmb_service.Items.Clear();
            Cmb_service.Items.Add("Nose Jobs");
            Cmb_service.Items.Add("Face Lifts");
            Cmb_service.Items.Add("Tummy Tuck");
            Cmb_service.Items.Add("Liposuction");
            Cmb_service.Items.Add("Eyelift");

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = System.Drawing.Color.Red;
            RadioButton2.ForeColor = System.Drawing.Color.Green;

            Cmb_service.Items.Clear();
            Cmb_service.Items.Add("Chemical Peel");
            Cmb_service.Items.Add("Skin Laser and Restoration");
            Cmb_service.Items.Add("Dermal Filler");
            Cmb_service.Items.Add("Pigmentation and Scar Reduction");
            Cmb_service.Items.Add("Botox Injection"); 

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = Txt_ic.Text;
            arr[1] = Txt_name.Text;
            arr[2] = Dtp_date.Text;
            arr[3] = Cmb_service.SelectedItem.ToString();

            ListViewItem lst = new ListViewItem(arr);
            ListView1.Items.Add(lst);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ListView1.Items.Count; i++)
                {
                    if (ListView1.Items[i].Selected)
                    {
                        ListView1.Items[i].Remove();
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Main_Page MP = new Main_Page();
            string message = "Do you want to save this appointment?";
            string title = "Save Appointment";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Appointment has been saved!");
                this.Hide(); 
                MP.ShowDialog();
            }
            else
            {
                this.Hide();
                MP.ShowDialog();
            }
        }
    }
}
