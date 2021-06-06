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
    public partial class Medication_Form : Form
    {
        public Medication_Form()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //service type
            SurgeryRB.Checked = true; // surgery radio button
            TreatmentRB.Checked = true; // treatment radio button

            DateTimePicker1.Format = DateTimePickerFormat.Long;
            DateTimePicker1.Value = DateTime.Today;

            // medication and charges
            MedNameComboBox.Items.Add("Tretinoin");// acne & sun damage medicine
            MedNameComboBox.Items.Add("Beta-hydroxy acid (salicylic acid)");//improve skin and color
            MedNameComboBox.Items.Add("Hydroquinone");////dark spot treatment

            //list view
            MedListView.View = View.Details;
            MedListView.FullRowSelect = true;
            
           
        }

       

        // add rows
        public void AddItems(string mediName, string Prescription, string Quantity, string Notes)
        {

            //array to replace row

            string[] row = { mediName, Prescription, Quantity, Notes };
            ListViewItem item = new ListViewItem(row);

            // add items
            MedListView.Items.Add(item);

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prescription for every medicine
            PrescriptionComboBox.Items.Clear();
            if (MedNameComboBox.SelectedItem == "Tretinoin")
            {
                PrescriptionComboBox.Items.Add("1 tablets x 7 days");
                PrescriptionComboBox.Items.Add("1 tablets x 14 days");
                PrescriptionComboBox.Items.Add("1 tablets x 28 days");
            }
            else if (MedNameComboBox.SelectedItem == "Beta-hydroxy acid (salicylic acid)")
            {
                PrescriptionComboBox.Items.Add("1 times per day");
                PrescriptionComboBox.Items.Add("2 times per day");
                PrescriptionComboBox.Items.Add("1 time per week");
            }
            else if (MedNameComboBox.SelectedItem == "Hydroquinone")
            {
                PrescriptionComboBox.Items.Add("1 times per day");
                PrescriptionComboBox.Items.Add("2 times per day");
                PrescriptionComboBox.Items.Add("1 time per week");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // items add in listview
            AddItems((string)MedNameComboBox.SelectedItem, (string)PrescriptionComboBox.SelectedItem, QuantityTxtBox.Text, NoteTxtBox.Text);

        }
        private void RemoveItem()
        {
            if(MessageBox.Show("Are you sure?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MedListView.Items.RemoveAt(MedListView.SelectedIndices[0]);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RemoveItem();

        }
        

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            string mediName = MedListView.SelectedItems[0].SubItems[0].Text;
            string Prescription = MedListView.SelectedItems[0].SubItems[1].Text;
            string Quantity = MedListView.SelectedItems[0].SubItems[2].Text;
            string Notes = MedListView.SelectedItems[0].SubItems[3].Text;

            MedNameComboBox.SelectedItem = mediName;
            PrescriptionComboBox.SelectedItem = Prescription;
            QuantityTxtBox.Text = Quantity;
            NoteTxtBox.Text = Notes;
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
       
        private void Button3_Click(object sender, EventArgs e)
        {
            string[] patient;
            patient = new string[1];
            for (int i = 0; i < patient.Length; i++)
            {
                patient[i] = NameTxtBox.Text;
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
                    this.Hide();
                }
            }

            SetValueForText1 = NameTxtBox.Text;//patient Name
            SetValueForText2 = IDTxtBox.Text;//patient ID
            
            if(SurgeryRB.Checked == true)
            {
                SetValueForText3 = SurgeryRB.Text;//surgery
            }
            else if(TreatmentRB.Checked == true)
            {
                SetValueForText3 = TreatmentRB.Text;//treatment
            }
            SetValueForText4 = DateTimePicker1.Text;//date
            SetValueForText5 = (string)TreatmentComboBox.SelectedItem;//surgery/treatment Name
           
            
            ClientDetailsForm Saveform = new ClientDetailsForm();
            this.Hide();
            Saveform.Show();
        }
        

        private void SurgeryRB_CheckedChanged(object sender, EventArgs e)
        {
            TreatmentComboBox.Items.Clear();
            // TYPE OF SURGERY
            if(SurgeryRB.Checked == true)
            {
                TreatmentComboBox.Items.Add("Nose Jobs");
                TreatmentComboBox.Items.Add("Face Lifts");
                TreatmentComboBox.Items.Add("Tummy Tuck");
                TreatmentComboBox.Items.Add("Liposuction");
                TreatmentComboBox.Items.Add("Eyelfit");
                TreatmentComboBox.Items.Add("Rhinoplasty");
            }
            //TYPE OF TREATMENT
            else if (TreatmentRB.Checked == true)
            {
                TreatmentComboBox.Items.Add("Chemical Peel");
                TreatmentComboBox.Items.Add("Skin Laser and Restoration");
                TreatmentComboBox.Items.Add("Derma Filler");
                TreatmentComboBox.Items.Add("Pigmentation and Scar Reduction");
                TreatmentComboBox.Items.Add("Botox Injection");
                TreatmentComboBox.Items.Add("Dermabrasion");

            }
        }
    }
}
