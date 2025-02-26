using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class Form3 : Form
    {
        public Form3(List<(string itemName, int quantity, double totalPrice)> receiptItems, string totalCost, string percentDiscount, string discountAmount, string finalAmount)
        {
            InitializeComponent();

            // Populate DataGridView with consolidated receipt items
            foreach (var item in receiptItems)
            {
                int rowIndex = receiptDataGridView.Rows.Add();  // Ensure correct reference
                receiptDataGridView.Rows[rowIndex].Cells[0].Value = item.itemName;  // Item Name
                receiptDataGridView.Rows[rowIndex].Cells[1].Value = item.quantity;  // Total Quantity
                receiptDataGridView.Rows[rowIndex].Cells[2].Value = $"₱{item.totalPrice:N2}";  // Total Price
            }

            // Display receipt summary details
            totalCostLabel.Text = totalCost;
            percentDiscountLabel.Text = percentDiscount;
            discountAmountLabel.Text = discountAmount;
            finalAmountLabel.Text = finalAmount;
        }

        private void Form3_Load(object sender, EventArgs e) { }



        private void totalCostLabel_Click(object sender, EventArgs e) { }

        private void percentDiscountLabel_Click(object sender, EventArgs e) { }

        private void discountAmountLabel_Click(object sender, EventArgs e) { }

        private void finalAmountLabel_Click(object sender, EventArgs e) { }

        private void receiptDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
