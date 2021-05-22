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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            String user = "Admin", password = "123456";
            if ((IDBox.Text == user) && (PasswordBox.Text == password))
            {
                MessageBox.Show("ID & Password is correct", "Not noice");
                this.Hide();
                Main_Page MP = new Main_Page();
                MP.ShowDialog();
            }
            else
            {
                MessageBox.Show("ID & Password is incorrect", "Not noice");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
