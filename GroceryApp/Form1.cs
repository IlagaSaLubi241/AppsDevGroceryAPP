namespace GroceryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Attach KeyDown event handlers for Enter key navigation
            itemNameTextBox.KeyDown += itemNameTextBox_KeyDown;
            quantityTextBox.KeyDown += quantityTextBox_KeyDown;
            pricePerUnitTextBox.KeyDown += pricePerUnitTextBox_KeyDown;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string itemName = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{itemName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItemToGrid();
        }
        private void AddItemToGrid()
        {
            string item = itemNameTextBox.Text;
            int quantity;
            double pricePerUnit;

            if (int.TryParse(item, out _))
            {
                MessageBox.Show("Please enter a valid item name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(pricePerUnitTextBox.Text, out pricePerUnit))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPrice = quantity * pricePerUnit;
            dataGridView1.Rows.Add(item, quantity, totalPrice);

            // Clear fields and set focus to the first input
            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            pricePerUnitTextBox.Clear();
            itemNameTextBox.Focus();
        }

        private void itemNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                quantityTextBox.Focus();
            }
        }

        private void quantityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                pricePerUnitTextBox.Focus();
            }
        }

        private void itemLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void pricePerUnitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddItemToGrid(); // Auto-add item on Enter
            }
        }
        private void pricePerUnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void discountPercentLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemLabel_Click(object sender, EventArgs e)
        {

        }
        private double calculatePrice()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && double.TryParse(row.Cells[2].Value.ToString(), out double totalPrice))
                {
                    sum += totalPrice;
                }
            }
            return sum;
        }
        private int calDiscount()
        {
            double totalPrice = calculatePrice();
            if (totalPrice < 100) return 0;
            else if (totalPrice < 200) return 10;
            else if (totalPrice <= 500) return 15;
            else return 20;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("No items to checkout. Please add items to the list.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount();
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            percentDiscountTextBox.Text = $"{discountPercentage}%";
            totalCostTextBox.Text = $"₱{totalPrice:N2}";
            discountAmountTextBox.Text = $"₱{discountAmount:N2}";
            totalAmountTextBox.Text = $"₱{finalPrice:N2}";
        }


        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void percentDiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("No items to checkout.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dictionary<string, (int quantity, double totalPrice)> receiptData = new Dictionary<string, (int, double)>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string itemName = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    double total = Convert.ToDouble(row.Cells[2].Value);

                    if (receiptData.ContainsKey(itemName))
                    {
                        receiptData[itemName] = (receiptData[itemName].quantity + quantity, receiptData[itemName].totalPrice + total);
                    }
                    else
                    {
                        receiptData[itemName] = (quantity, total);
                    }
                }
            }

            List<(string itemName, int quantity, double totalPrice)> receiptItems =
                receiptData.Select(kvp => (kvp.Key, kvp.Value.quantity, kvp.Value.totalPrice)).ToList();

            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount();
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            string formattedTotalCost = $"₱{totalPrice:N2}";
            string formattedPercentDiscount = $"{discountPercentage}%";
            string formattedDiscountAmount = $"₱{discountAmount:N2}";
            string formattedFinalAmount = $"₱{finalPrice:N2}";

            Form3 receiptForm = new Form3(receiptItems, formattedTotalCost, formattedPercentDiscount, formattedDiscountAmount, formattedFinalAmount);
            receiptForm.ShowDialog();

            dataGridView1.Rows.Clear();
            percentDiscountTextBox.Clear();
            totalAmountTextBox.Clear();
            discountAmountTextBox.Clear();
            totalCostTextBox.Clear();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
