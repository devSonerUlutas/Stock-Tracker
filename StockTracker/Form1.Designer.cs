namespace StockTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            updateOrDeleteToolStripMenuItem = new ToolStripMenuItem();
            stockUpdateToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            allProductsReportToolStripMenuItem = new ToolStripMenuItem();
            transactionReportToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsToolStripMenuItem, stockUpdateToolStripMenuItem, reportToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, updateOrDeleteToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(162, 22);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // updateOrDeleteToolStripMenuItem
            // 
            updateOrDeleteToolStripMenuItem.Name = "updateOrDeleteToolStripMenuItem";
            updateOrDeleteToolStripMenuItem.Size = new Size(162, 22);
            updateOrDeleteToolStripMenuItem.Text = "Update or Delete";
            updateOrDeleteToolStripMenuItem.Click += updateOrDeleteToolStripMenuItem_Click;
            // 
            // stockUpdateToolStripMenuItem
            // 
            stockUpdateToolStripMenuItem.Name = "stockUpdateToolStripMenuItem";
            stockUpdateToolStripMenuItem.Size = new Size(89, 20);
            stockUpdateToolStripMenuItem.Text = "Stock Update";
            stockUpdateToolStripMenuItem.Click += stockUpdateToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allProductsReportToolStripMenuItem, transactionReportToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(57, 20);
            reportToolStripMenuItem.Text = "Report ";
            // 
            // allProductsReportToolStripMenuItem
            // 
            allProductsReportToolStripMenuItem.Name = "allProductsReportToolStripMenuItem";
            allProductsReportToolStripMenuItem.Size = new Size(180, 22);
            allProductsReportToolStripMenuItem.Text = "All Products Report";
            allProductsReportToolStripMenuItem.Click += allProductsReportToolStripMenuItem_Click;
            // 
            // transactionReportToolStripMenuItem
            // 
            transactionReportToolStripMenuItem.Name = "transactionReportToolStripMenuItem";
            transactionReportToolStripMenuItem.Size = new Size(180, 22);
            transactionReportToolStripMenuItem.Text = "Transaction Report";
            transactionReportToolStripMenuItem.Click += transactionReportToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 550);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem updateOrDeleteToolStripMenuItem;
        private ToolStripMenuItem stockUpdateToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem allProductsReportToolStripMenuItem;
        private ToolStripMenuItem transactionReportToolStripMenuItem;
    }
}