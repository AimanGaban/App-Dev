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
    public partial class Form2 : Form
    {
     

        public Form2()
        {
            InitializeComponent();
            
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {

            PNLabel.Text = Form1.SetValueForText1;
            PatientIDLabel.Text = Form1.SetValueForText2;
            STLabel.Text = Form1.SetValueForText3;
            DateLabel.Text = Form1.SetValueForText4;
            STNameLabel.Text = Form1.SetValueForText5;

           



        }

     


    }
}
