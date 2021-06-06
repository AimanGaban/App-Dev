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
    public partial class ClientDetailsForm : Form
    {
     

        public ClientDetailsForm()
        {
            InitializeComponent();
            
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {

            PNLabel.Text = Medication_Form.SetValueForText1;
            PatientIDLabel.Text = Medication_Form.SetValueForText2;
            STLabel.Text = Medication_Form.SetValueForText3;
            DateLabel.Text = Medication_Form.SetValueForText4;
            STNameLabel.Text = Medication_Form.SetValueForText5;

           



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Main_Page MP = new Main_Page();
            this.Hide();
            MP.ShowDialog();
        }
    }
}
