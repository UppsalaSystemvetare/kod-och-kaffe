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

        //This method is called when a user checks or unchecks the "Decrypt?"-checkbox
        private void check_Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            //check_Decrypt = Name of the checkbox
            //Checked = a property that checks if the checkbox is checked or not
            if (check_Decrypt.Checked == true)
            {
                //This changes the text on the submit button to "Decrypt".
                // (button_submit is the name of the button)
                button_Submit.Text = "Decrypt!";
            }
            else
            {
                button_Submit.Text = "Encrypt!";
            }
        }
    }
}
