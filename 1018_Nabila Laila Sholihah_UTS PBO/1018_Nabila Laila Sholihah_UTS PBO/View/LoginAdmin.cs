using _1018_Nabila_Laila_Sholihah_UTS_PBO.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1018_Nabila_Laila_Sholihah_UTS_PBO.View
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool isValid = AdminContext.LoginUser(username, password);
            if (isValid)
            {
                MessageBox.Show("Berhasil Login");
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
