using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracker.Reports
{
    public partial class AllProDetails : Form
    {
        CommonMethods cm = new CommonMethods();

        public AllProDetails()
        {
            InitializeComponent();
        }

        private void AllProDetails_Load(object sender, EventArgs e)
        {
            loadAllData();
            loadGridData("select p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice,sum(s.quantity) as Quantity from Products p LEFT JOIN Stock s ON p.proid = s.proid group by p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice");
        }

        public void loadAllData()
        {
            cmbProName.Items.Clear();
            cmbProName.Text = "";
            cm.loadDataCB("select proname from Products", cmbProName);
        }

        public void loadGridData(string str)
        {
            cm.loadDataGrid(str, dataGridView1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadAllData();
            loadGridData("select p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice,sum(s.quantity) as Quantity from Products p LEFT JOIN Stock s ON p.proid = s.proid group by p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice");
        }

        private void cmbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProName.Text != "")
            {
                loadGridData("select p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice,sum(s.quantity) as Quantity from Products p LEFT JOIN Stock s ON p.proid = s.proid where p.proname='"+cmbProName.Text+"' group by p.proid,p.proname,p.category,p.unit,p.salesprice,p.purchaseprice");
            }
        }
    }
}
