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
    public partial class Product_Addition : Form
    {
        CommonMethods cm = new CommonMethods();

        public Product_Addition()
        {
            InitializeComponent();
            txtSPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
            txtPPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProName.Text != "" && txtProCategory.Text != "" && txtUnit.Text != "" && txtSPrice.Text != "" && txtPPrice.Text != "")
            {
                cm.ExecuteSQLQuery("insert into Products(proname,category,unit,salesprice,purchaseprice) values('" + txtProName.Text + "', '" + txtProCategory.Text + "', '" + txtUnit.Text + "', '" + txtPPrice.Text + "', " + txtPPrice.Text + ")");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProName.Text = "";
            txtProCategory.Text = "";
            txtUnit.Text = "";
            txtSPrice.Text = "";
            txtPPrice.Text = "";

        }

        private void Product_Addition_Load(object sender, EventArgs e)
        {

        }
    }
}
