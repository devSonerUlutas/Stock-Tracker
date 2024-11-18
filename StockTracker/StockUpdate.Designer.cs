namespace StockTracker
{
    partial class StockUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            cmbProName = new ComboBox();
            label8 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnUpdate = new Button();
            panel3 = new Panel();
            txtPresentQty = new TextBox();
            label6 = new Label();
            txtProId = new TextBox();
            label7 = new Label();
            txtPPrice = new TextBox();
            txtSPrice = new TextBox();
            txtUnit = new TextBox();
            txtProCategory = new TextBox();
            txtProName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            txtNewQty = new TextBox();
            btnMinus = new Button();
            label10 = new Label();
            btnPlus = new Button();
            txtUpdateQty = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProName);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(148, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 77);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Product";
            // 
            // cmbProName
            // 
            cmbProName.FormattingEnabled = true;
            cmbProName.Location = new Point(130, 34);
            cmbProName.Name = "cmbProName";
            cmbProName.Size = new Size(259, 29);
            cmbProName.TabIndex = 31;
            cmbProName.SelectedIndexChanged += cmbProName_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 37);
            label8.Name = "label8";
            label8.Size = new Size(113, 21);
            label8.TabIndex = 30;
            label8.Text = "Product Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(516, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(186, 29);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 42);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPresentQty);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtProId);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtPPrice);
            panel3.Controls.Add(txtSPrice);
            panel3.Controls.Add(txtUnit);
            panel3.Controls.Add(txtProCategory);
            panel3.Controls.Add(txtProName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 420);
            panel3.TabIndex = 2;
            // 
            // txtPresentQty
            // 
            txtPresentQty.Enabled = false;
            txtPresentQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPresentQty.Location = new Point(147, 362);
            txtPresentQty.Name = "txtPresentQty";
            txtPresentQty.Size = new Size(255, 29);
            txtPresentQty.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 365);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 40;
            label6.Text = "Present Qty:";
            // 
            // txtProId
            // 
            txtProId.Enabled = false;
            txtProId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProId.Location = new Point(147, 61);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(255, 29);
            txtProId.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 64);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 38;
            label7.Text = "Product ID:";
            // 
            // txtPPrice
            // 
            txtPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPPrice.Location = new Point(147, 310);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(255, 29);
            txtPPrice.TabIndex = 37;
            // 
            // txtSPrice
            // 
            txtSPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSPrice.Location = new Point(147, 260);
            txtSPrice.Name = "txtSPrice";
            txtSPrice.Size = new Size(255, 29);
            txtSPrice.TabIndex = 36;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(147, 212);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(255, 29);
            txtUnit.TabIndex = 35;
            // 
            // txtProCategory
            // 
            txtProCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProCategory.Location = new Point(147, 161);
            txtProCategory.Name = "txtProCategory";
            txtProCategory.Size = new Size(255, 29);
            txtProCategory.TabIndex = 34;
            // 
            // txtProName
            // 
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProName.Location = new Point(147, 108);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(255, 29);
            txtProName.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 313);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 32;
            label5.Text = "Purchase Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 263);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 31;
            label4.Text = "Sales Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 215);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 30;
            label3.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 164);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 29;
            label2.Text = "Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 111);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 28;
            label1.Text = "Product Name:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtNewQty);
            panel4.Controls.Add(btnMinus);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btnPlus);
            panel4.Controls.Add(txtUpdateQty);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(428, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 420);
            panel4.TabIndex = 3;
            // 
            // txtNewQty
            // 
            txtNewQty.Enabled = false;
            txtNewQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewQty.Location = new Point(108, 188);
            txtNewQty.Name = "txtNewQty";
            txtNewQty.Size = new Size(226, 29);
            txtNewQty.TabIndex = 43;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(220, 114);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(81, 40);
            btnMinus.TabIndex = 44;
            btnMinus.Text = "Minus";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(25, 191);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 42;
            label10.Text = "New Qty:";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(46, 114);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(81, 40);
            btnPlus.TabIndex = 43;
            btnPlus.Text = "Plus";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtUpdateQty
            // 
            txtUpdateQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdateQty.Location = new Point(46, 61);
            txtUpdateQty.Name = "txtUpdateQty";
            txtUpdateQty.Size = new Size(255, 29);
            txtUpdateQty.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(110, 15);
            label9.Name = "label9";
            label9.Size = new Size(132, 19);
            label9.TabIndex = 42;
            label9.Text = "Update Quantity";
            // 
            // StockUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StockUpdate";
            Text = "StockUpdate";
            Load += StockUpdate_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox cmbProName;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtProId;
        private Label label7;
        private TextBox txtPPrice;
        private TextBox txtSPrice;
        private TextBox txtUnit;
        private TextBox txtProCategory;
        private TextBox txtProName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPresentQty;
        private Label label6;
        private Label label9;
        private Button btnMinus;
        private Button btnPlus;
        private TextBox txtUpdateQty;
        private Button btnClear;
        private Button btnUpdate;
        private TextBox txtNewQty;
        private Label label10;
    }
}