using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extension_Look_Up
{
    public partial class passwordCheckerForm : Form
    {
        private string updatePassword;

        public passwordCheckerForm()
        {
            InitializeComponent();
        }

        private void passwordCheckerForm_Load(object sender, EventArgs e)
        {
            updatePassword = "nbhcdata";
        }
        
        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == updatePassword)
            {
                MessageBox.Show("Password accepted");
                extUpdateForm ext = new extUpdateForm();
                ext.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
