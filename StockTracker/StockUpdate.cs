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
    public partial class StockUpdate : Form
    {
        CommonMethods cm = new CommonMethods();

        public StockUpdate()
        {
            InitializeComponent();
            txtSPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
            txtPPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
            txtUpdateQty.KeyPress += new KeyPressEventHandler(cm.numericOnly);
        }

        private void cmbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProName.Text != "")
            {
                string str = "select proid, proname, category, unit, salesprice, purchase from Products where proname = '" + cmbProName.Text + "'";

                cm.retrieveData(str, txtProId, 0);
                cm.retrieveData(str, txtProName, 1);
                cm.retrieveData(str, txtProCategory, 2);
                cm.retrieveData(str, txtUnit, 3);
                cm.retrieveData(str, txtSPrice, 4);
                cm.retrieveData(str, txtPPrice, 5);

                string curqty = "";
                curqty = cm.getstringfromquery("select sum(quantity) from Stock where proid = '" + txtProId.Text + "'", curqty);
                if (curqty != "")
                    txtPresentQty.Text = curqty;
                else
                    txtPresentQty.Text = "0";

            }
            else
            {
                MessageBox.Show("Lütfen ürün seçin.");
            }
        }

        public void clear()
        {
            txtProId.Text = "";
            txtProName.Text = "";
            txtProCategory.Text = "";
            txtUnit.Text = "";
            txtSPrice.Text = "";
            txtPPrice.Text = "";
            cmbProName.Text = "";
            txtPresentQty.Text = "";
            txtUpdateQty.Text = "";
            txtNewQty.Text = "";
            cmbProName.Items.Clear();
            cm.loadDataCB("select proname from Products", cmbProName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void StockUpdate_Load(object sender, EventArgs e)
        {
            clear();
        }

        int upqty = 0;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtPresentQty.Text != "" && txtUpdateQty.Text != "")
            {
                txtNewQty.Text = (int.Parse(txtPresentQty.Text) + int.Parse(txtUpdateQty.Text)).ToString();
                upqty = int.Parse(txtUpdateQty.Text);
            }
            else
            {
                MessageBox.Show("Boş bırakılamaz");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtPresentQty.Text != "" && txtUpdateQty.Text != "")
            {
                txtNewQty.Text = (int.Parse(txtPresentQty.Text) - int.Parse(txtUpdateQty.Text)).ToString();
                upqty = int.Parse(txtUpdateQty.Text) * (-1);

            }
            else
            {
                MessageBox.Show("Boş bırakılamaz");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProId.Text != "" && txtUpdateQty.Text != "")
            {
                cm.ExecuteSQLQuery("insert into Stock (proid,quantity,txndate,usarname) values ('" + txtProId.Text + "', " + upqty + ", '"+DateTime.Today+"', '"+GlobalData.uname+"')");
                MessageBox.Show("Stok başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Ürün seçin veya miktar girin.");
            }
        }
    }
}
