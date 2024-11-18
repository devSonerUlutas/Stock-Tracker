using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracker
{
    public partial class LoginForm : Form
    {
        CommonMethods cm = new CommonMethods();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //retrieve, check
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                string passw = "";
                passw = cm.getstringfromquery("select password from Login where username= '" + txtUsername.Text + "'", passw);
                if(passw == txtPassword.Text)
                {
                    GlobalData.uname = txtUsername.Text;
                    MessageBox.Show("Hoşgediniz :)");
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
