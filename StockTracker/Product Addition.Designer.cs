namespace StockTracker
{
    partial class Product_Addition
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProName = new TextBox();
            txtProCategory = new TextBox();
            txtUnit = new TextBox();
            txtSPrice = new TextBox();
            txtPPrice = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 76);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 129);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 180);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 2;
            label3.Text = "Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 228);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Sales Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(108, 278);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 4;
            label5.Text = "Purchase Price:";
            // 
            // txtProName
            // 
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProName.Location = new Point(227, 73);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(255, 29);
            txtProName.TabIndex = 5;
            // 
            // txtProCategory
            // 
            txtProCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProCategory.Location = new Point(227, 126);
            txtProCategory.Name = "txtProCategory";
            txtProCategory.Size = new Size(255, 29);
            txtProCategory.TabIndex = 6;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(227, 177);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(255, 29);
            txtUnit.TabIndex = 7;
            // 
            // txtSPrice
            // 
            txtSPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSPrice.Location = new Point(227, 225);
            txtSPrice.Name = "txtSPrice";
            txtSPrice.Size = new Size(255, 29);
            txtSPrice.TabIndex = 8;
            // 
            // txtPPrice
            // 
            txtPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPPrice.Location = new Point(227, 275);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(255, 29);
            txtPPrice.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(227, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(384, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(227, 9);
            label6.Name = "label6";
            label6.Size = new Size(184, 30);
            label6.TabIndex = 12;
            label6.Text = "Product Addition";
            // 
            // Product_Addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtPPrice);
            Controls.Add(txtSPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtProCategory);
            Controls.Add(txtProName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Product_Addition";
            Text = "Product_Addition";
            Load += Product_Addition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProName;
        private TextBox txtProCategory;
        private TextBox txtUnit;
        private TextBox txtSPrice;
        private TextBox txtPPrice;
        private Button btnSave;
        private Button btnClear;
        private Label label6;
    }
}