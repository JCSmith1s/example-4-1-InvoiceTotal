namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            label1 = new Label();
            txtEnterSubtotal = new TextBox();
            txtDiscountPct = new TextBox();
            label2 = new Label();
            txtDiscountAmt = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnCalculate = new Button();
            label5 = new Label();
            label6 = new Label();
            txtNumberOfInvoices = new TextBox();
            label7 = new Label();
            txtSubtotal = new TextBox();
            label8 = new Label();
            btnClearTotals = new Button();
            txtAvgOfInvoices = new TextBox();
            txtTotalOfInvoices = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Subtotal:";
            label1.Click += label1_Click;
            // 
            // txtEnterSubtotal
            // 
            txtEnterSubtotal.Location = new Point(146, 22);
            txtEnterSubtotal.Name = "txtEnterSubtotal";
            txtEnterSubtotal.Size = new Size(100, 23);
            txtEnterSubtotal.TabIndex = 1;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(146, 94);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(100, 23);
            txtDiscountPct.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(146, 134);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(100, 23);
            txtDiscountAmt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(146, 174);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(27, 177);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(334, 235);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(253, 235);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(274, 163);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 14;
            label5.Text = "Average of invoices:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(274, 123);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 12;
            label6.Text = "Total of invoices:";
            // 
            // txtNumberOfInvoices
            // 
            txtNumberOfInvoices.Location = new Point(393, 81);
            txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            txtNumberOfInvoices.ReadOnly = true;
            txtNumberOfInvoices.Size = new Size(100, 23);
            txtNumberOfInvoices.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(274, 84);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 10;
            label7.Text = "Number of invoices:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(146, 57);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(27, 60);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 16;
            label8.Text = "Subtotal:";
            // 
            // btnClearTotals
            // 
            btnClearTotals.Location = new Point(415, 235);
            btnClearTotals.Name = "btnClearTotals";
            btnClearTotals.Size = new Size(75, 23);
            btnClearTotals.TabIndex = 18;
            btnClearTotals.Text = "Clear";
            btnClearTotals.UseVisualStyleBackColor = true;
            // 
            // txtAvgOfInvoices
            // 
            txtAvgOfInvoices.Location = new Point(393, 160);
            txtAvgOfInvoices.Name = "txtAvgOfInvoices";
            txtAvgOfInvoices.ReadOnly = true;
            txtAvgOfInvoices.Size = new Size(100, 23);
            txtAvgOfInvoices.TabIndex = 15;
            // 
            // txtTotalOfInvoices
            // 
            txtTotalOfInvoices.Location = new Point(393, 120);
            txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            txtTotalOfInvoices.ReadOnly = true;
            txtTotalOfInvoices.Size = new Size(100, 23);
            txtTotalOfInvoices.TabIndex = 13;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(519, 271);
            Controls.Add(btnClearTotals);
            Controls.Add(txtSubtotal);
            Controls.Add(label8);
            Controls.Add(txtAvgOfInvoices);
            Controls.Add(label5);
            Controls.Add(txtTotalOfInvoices);
            Controls.Add(label6);
            Controls.Add(txtNumberOfInvoices);
            Controls.Add(label7);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtEnterSubtotal);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnterSubtotal;
        private TextBox txtDiscountPct;
        private Label label2;
        private TextBox txtDiscountAmt;
        private Label label3;
        private TextBox txtTotal;
        private Label label4;
        private Button btnExit;
        private Button btnCalculate;
        private Label label5;
        private Label label6;
        private TextBox txtNumberOfInvoices;
        private Label label7;
        private TextBox txtSubtotal;
        private Label label8;
        private Button btnClearTotals;
        private TextBox txtAvgOfInvoices;
        private TextBox txtTotalOfInvoices;
    }
}
