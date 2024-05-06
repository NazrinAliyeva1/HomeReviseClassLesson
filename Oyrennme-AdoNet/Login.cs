using Oyrennme_AdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyrennme_AdoNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = SqlHelper.ExecuteQuery($"SELECT Id FROM Users WHERE Username = '{username.Text}' and Password = '{password.Text}'");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Xos gelmisiniz.");
            }
            else
            {
                MessageBox.Show("Istifadeci adi ve ya parolu yanlisdir.");
            }
        }

        private void registerHref_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
