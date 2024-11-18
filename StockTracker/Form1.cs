namespace StockTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Addition pa = new Product_Addition();
            pa.ShowDialog();
        }

        private void updateOrDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductUpdateDelete pd = new ProductUpdateDelete();
            pd.ShowDialog();
        }

        private void stockUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockUpdate su = new StockUpdate();
            su.Show();
        }

        private void allProductsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.AllProDetails ap = new Reports.AllProDetails();
            ap.ShowDialog();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.TransactionDetails td = new Reports.TransactionDetails();
            td.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}