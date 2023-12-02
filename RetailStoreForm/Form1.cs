using System;
using System.Windows.Forms;

namespace RetailStoreForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BillingForm
            BillingForm billingForm = new BillingForm();

            // Calculate the total amount based on checked items and quantities
            int totalAmount = CalculateTotalAmount();

            // Display the total amount in the BillingForm
            billingForm.SetTotalAmount(totalAmount);

            // Show the BillingForm as a dialog
            billingForm.ShowDialog();
        }

        private int CalculateTotalAmount()
        {
            // Assuming each product costs $5
            int costPerProduct = 5;
            int costPerProduct_One = 40;
            int costPerProduct_Two = 30;
            int costPerProduct_Three = 100;
            int costPerProduct_Four = 30;
            int costPerProduct_Five = 1200;

            // Calculate the total amount based on checked items and quantities
            int totalAmount = 0;

            if (checkBox1.Checked)
                totalAmount += (int)numericUpDown1.Value * costPerProduct_One;

            if (checkBox2.Checked)
                totalAmount += (int)numericUpDown2.Value * costPerProduct_Two;

            if (checkBox3.Checked)
                totalAmount += (int)numericUpDown3.Value * costPerProduct_Three;

            if (checkBox4.Checked)
                totalAmount += (int)numericUpDown4.Value * costPerProduct_Four;

            if (checkBox5.Checked)
                totalAmount += (int)numericUpDown5.Value * costPerProduct_Five;

            return totalAmount + costPerProduct;
        }
    }

    // New form for billing summary
    public class BillingForm : Form
    {
        private Label labelTotalAmount;
        private Button buttonClose;

        public BillingForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelTotalAmount = new Label();
            buttonClose = new Button();

            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new System.Drawing.Point(12, 9);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new System.Drawing.Size(100, 20);
            labelTotalAmount.TabIndex = 0;
            labelTotalAmount.Text = "Total Amount: $0";

            buttonClose.Location = new System.Drawing.Point(197, 49);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 30);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += new System.EventHandler(buttonClose_Click);

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 91);
            Controls.Add(buttonClose);
            Controls.Add(labelTotalAmount);
            Name = "BillingForm";
            Text = "Billing Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        public void SetTotalAmount(int totalAmount)
        {
            labelTotalAmount.Text = $"Total Amount: ${totalAmount}\nTotal Taxes(Fixed): ${5}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 