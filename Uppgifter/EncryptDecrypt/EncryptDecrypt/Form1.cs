using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            //Check if checkbox is checked
            if (check_Decrypt.Checked)
            {
                //Change text on submit button
                button_Submit.Text = "Decrypt!";
            }
            else
            {
                button_Submit.Text = "Encrypt!";
            }
        }
    }
}
