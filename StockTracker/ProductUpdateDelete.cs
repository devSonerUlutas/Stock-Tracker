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
    public partial class ProductUpdateDelete : Form
    {
        CommonMethods cm = new CommonMethods();

        public ProductUpdateDelete()
        {
            InitializeComponent();
            txtPPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
            txtSPrice.KeyPress += new KeyPressEventHandler(cm.numericOnly);
        }

        private void ProductUpdateDelete_Load(object sender, EventArgs e)
        {
            clear();
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

            }
            else
            {
                MessageBox.Show("Lütfen ürün seçin.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProId.Text != "" && txtProName.Text != "" && txtProCategory.Text != "" && txtUnit.Text != "" && txtSPrice.Text != "" && txtPPrice.Text != "")
            {
                cm.ExecuteSQLQuery("update Products set proname = '" + txtProName.Text + "', category = '" + txtProCategory.Text + "', unit = '" + txtUnit.Text + "', saleprice = " + txtSPrice.Text + ", purchaseprice= " + txtPPrice.Text + ", where proid = '" + txtProId.Text + "'");
                MessageBox.Show("Başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProId.Text != "")
            {
                cm.ExecuteSQLQuery("delete from Products where proid = '" + txtProId.Text + "'");
                MessageBox.Show("Kayıt silme işlemi başarılı.");
                clear();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçiniz.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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
            cmbProName.Items.Clear();
            cm.loadDataCB("select proname from Products", cmbProName);
        }
    }
}
