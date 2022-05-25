using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtBoxName.Text;
            var gender = string.Empty;
            if (rbtnMale.Checked)
                gender = rbtnMale.Text;
            else
                gender = rbtnFemale.Text;

            var address = txtBoxAddress.Text;
            var location = cBoxLocation.SelectedItem.ToString();
            var technology = lstBoxTechnology.SelectedItem.ToString();

            var message = $"Name={username} \n Gender={gender}\n Address={address}\n Location={location}\n Technology={technology}";

            labelMessage.Text = message;

            MessageBox.Show("Registration Successful");
        }
    }
}
