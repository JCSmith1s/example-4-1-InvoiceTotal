namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal avgOfInvoices = 0m;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
            * This method calculates the total for an
            * invoice depending on a
            * discount that's based on the subtotal.
             */

            // get the subtotal amount from the Subtotal text box decimal subtotal = Convert.ToDecimal (txtSubtotal.Text);

            // set the discountPct variable based
            // on the value of the subtotal variable decimal discountPct = 0m;   
            decimal subtotal = decimal.Parse(txtEnterSubtotal.Text);   // The m indicates a decimal value
            decimal discountPct = .25m;

            /*if (subtotal >= 500)
            {
                discountPct = .2m;
            }
            else if (subtotal >= 250)
            {
                discountPct = .15m;
            }
            else if (subtotal >= 100)
            {
                discountPct = .1m;
            } */

            /* calculate and assign the values for the
             * discountAmt and invoiceTotal variables
             * decimal discountAmt = subtotal * discountPct;
             * decimal invoiceTotal = subtotal - discountAmt;
             */


            decimal discountAmount = Math.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Math.Round(subtotal - discountAmount, 2);

            // format the values and display them in their text boxes
            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPct.Text = discountPct.ToString("p1");  // percent format with 1 decimal place
            txtDiscountAmt.Text = discountAmount.ToString("c"); // currency format
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            avgOfInvoices = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtAvgOfInvoices.Text = avgOfInvoices.ToString("c");

            txtEnterSubtotal.Text = "";
            // move the focus to the Subtotal text box
            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            avgOfInvoices = 0m;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtAvgOfInvoices.Text = "";

            txtEnterSubtotal.Focus();
        }
        
    }
}
