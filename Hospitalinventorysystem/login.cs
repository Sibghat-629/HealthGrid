using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalinventorysystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            admin.Text = " ";
            password.Text = " ";
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(admin.Text == " "  && password.Text == " ") {
                MessageBox.Show("missing information");
            }
            
            else if(admin.Text == "admin" && password.Text == "password") {
                menu obj = new menu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("enter the correct username and password");
            }
        }
    }
}
