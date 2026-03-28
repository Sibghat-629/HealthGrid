using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalinventorysystem
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


      
        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeform = null;

        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }

            activeform = childform;
            childform.TopLevel = false;

            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel.Controls.Add(childform);
            panel.Tag = childform;  // Corrected from panel.Tag to panel1.Tag
            childform.BringToFront();
            childform.Show();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            openchildform(new Doctor());
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            openchildform(new Patient());
        }

        private void Diagnosis_Click(object sender, EventArgs e)
        {
            openchildform(new Diagnosis());
        }

        private void Hospitall_Click(object sender, EventArgs e)
        {
            openchildform(new Hospitall());
        }








        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {
            openchildform(new aboutus());
        }

        

        private void recipts_Click(object sender, EventArgs e)
        {
            openchildform (new Recipt());
        }
    }
}
