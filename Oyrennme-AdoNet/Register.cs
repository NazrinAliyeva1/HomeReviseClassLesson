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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameVal = name.Text;
            string surnameVal = surname.Text;
            string genderVal = gender.Text.StartsWith("K") ? "Kisi": "Qadin";
            string usernameVal = username.Text;
            string passwordVal = password.Text;
            
            var result = SqlHelper.Execute($"INSERT INTO Users (Name, Surname, Gender, Username, Password) VALUES (N'{nameVal}', N'{surnameVal}', N'{genderVal}', N'{usernameVal}', N'{passwordVal}')");
            if (result == 0)
            {
                MessageBox.Show("Xəta baş verdi.");
            }
            else
            {
                MessageBox.Show("Ugurla qeydiyyatdan kecirildi.");
            }
        }
    }
}
