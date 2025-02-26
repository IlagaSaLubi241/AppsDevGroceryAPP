namespace GroceryApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            itemLabel = new Label();
            quantityLabel = new Label();
            pricePerUnitLabel = new Label();
            fillUpPanel = new Panel();
            pricePerUnitTextBox = new TextBox();
            quantityTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            addButton = new Button();
            calcuPanel = new Panel();
            totalAmountTextBox = new TextBox();
            discountAmountTextBox = new TextBox();
            percentDiscountTextBox = new TextBox();
            totalCostTextBox = new TextBox();
            doneButton = new Button();
            totalAmount = new Label();
            discountAmountLabel = new Label();
            discountPercentLabel = new Label();
            totalCostLabel = new Label();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            checkOutButton = new Button();
            cartLabel = new Label();
            fillUpPanel.SuspendLayout();
            calcuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.Location = new Point(34, 49);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(120, 25);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "ITEM NAME:";
            itemLabel.Click += itemLabel_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.FlatStyle = FlatStyle.Popup;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(43, 106);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(110, 25);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "QUANTITY:";
            // 
            // pricePerUnitLabel
            // 
            pricePerUnitLabel.AutoSize = true;
            pricePerUnitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePerUnitLabel.Location = new Point(3, 163);
            pricePerUnitLabel.Name = "pricePerUnitLabel";
            pricePerUnitLabel.Size = new Size(154, 25);
            pricePerUnitLabel.TabIndex = 2;
            pricePerUnitLabel.Text = "PRICE PER UNIT:";
            // 
            // fillUpPanel
            // 
            fillUpPanel.BackColor = Color.LightGray;
            fillUpPanel.BorderStyle = BorderStyle.Fixed3D;
            fillUpPanel.Controls.Add(pricePerUnitTextBox);
            fillUpPanel.Controls.Add(quantityTextBox);
            fillUpPanel.Controls.Add(itemNameTextBox);
            fillUpPanel.Controls.Add(addButton);
            fillUpPanel.Controls.Add(pricePerUnitLabel);
            fillUpPanel.Controls.Add(quantityLabel);
            fillUpPanel.Controls.Add(itemLabel);
            fillUpPanel.Location = new Point(91, 358);
            fillUpPanel.Name = "fillUpPanel";
            fillUpPanel.Size = new Size(397, 275);
            fillUpPanel.TabIndex = 3;
            // 
            // pricePerUnitTextBox
            // 
            pricePerUnitTextBox.Location = new Point(171, 163);
            pricePerUnitTextBox.Name = "pricePerUnitTextBox";
            pricePerUnitTextBox.Size = new Size(121, 31);
            pricePerUnitTextBox.TabIndex = 6;
            pricePerUnitTextBox.TextChanged += pricePerUnitTextBox_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(171, 106);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(121, 31);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(171, 49);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(176, 31);
            itemNameTextBox.TabIndex = 4;
            itemNameTextBox.TextChanged += itemLabel_TextChanged;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonHighlight;
            addButton.BackgroundImageLayout = ImageLayout.Zoom;
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(155, 218);
            addButton.Name = "addButton";
            addButton.Size = new Size(64, 40);
            addButton.TabIndex = 3;
            addButton.Tag = "";
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // calcuPanel
            // 
            calcuPanel.BackColor = Color.LightGray;
            calcuPanel.BorderStyle = BorderStyle.Fixed3D;
            calcuPanel.Controls.Add(totalAmountTextBox);
            calcuPanel.Controls.Add(discountAmountTextBox);
            calcuPanel.Controls.Add(percentDiscountTextBox);
            calcuPanel.Controls.Add(totalCostTextBox);
            calcuPanel.Controls.Add(doneButton);
            calcuPanel.Controls.Add(totalAmount);
            calcuPanel.Controls.Add(discountAmountLabel);
            calcuPanel.Controls.Add(discountPercentLabel);
            calcuPanel.Controls.Add(totalCostLabel);
            calcuPanel.Location = new Point(649, 409);
            calcuPanel.Name = "calcuPanel";
            calcuPanel.Size = new Size(439, 233);
            calcuPanel.TabIndex = 5;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.BackColor = SystemColors.ButtonHighlight;
            totalAmountTextBox.Location = new Point(222, 146);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(184, 31);
            totalAmountTextBox.TabIndex = 15;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // discountAmountTextBox
            // 
            discountAmountTextBox.BackColor = SystemColors.ButtonHighlight;
            discountAmountTextBox.Location = new Point(222, 108);
            discountAmountTextBox.Name = "discountAmountTextBox";
            discountAmountTextBox.ReadOnly = true;
            discountAmountTextBox.Size = new Size(184, 31);
            discountAmountTextBox.TabIndex = 14;
            discountAmountTextBox.TextChanged += discountAmountTextBox_TextChanged;
            // 
            // percentDiscountTextBox
            // 
            percentDiscountTextBox.BackColor = SystemColors.ButtonHighlight;
            percentDiscountTextBox.Location = new Point(222, 71);
            percentDiscountTextBox.Name = "percentDiscountTextBox";
            percentDiscountTextBox.ReadOnly = true;
            percentDiscountTextBox.Size = new Size(184, 31);
            percentDiscountTextBox.TabIndex = 13;
            percentDiscountTextBox.TextChanged += percentDiscountTextBox_TextChanged;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.BackColor = SystemColors.ButtonHighlight;
            totalCostTextBox.Location = new Point(222, 34);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.ReadOnly = true;
            totalCostTextBox.Size = new Size(184, 31);
            totalCostTextBox.TabIndex = 12;
            totalCostTextBox.TextChanged += totalCostTextBox_TextChanged;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(160, 183);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(112, 34);
            doneButton.TabIndex = 8;
            doneButton.Text = "DONE";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(49, 149);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(154, 25);
            totalAmount.TabIndex = 11;
            totalAmount.Text = "TOTAL AMOUNT";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountAmountLabel.Location = new Point(15, 111);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(191, 25);
            discountAmountLabel.TabIndex = 10;
            discountAmountLabel.Text = "DISCOUNT AMOUNT";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentLabel.Location = new Point(15, 77);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new Size(188, 25);
            discountPercentLabel.TabIndex = 9;
            discountPercentLabel.Text = "PERCENT DISCOUNT";
            discountPercentLabel.Click += discountPercentLabel_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCostLabel.Location = new Point(85, 40);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(118, 25);
            totalCostLabel.TabIndex = 8;
            totalCostLabel.Text = "TOTAL COST";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(577, 669);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 7;
            exitButton.Text = "CLOSE";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 316);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, quantity, totalPrice, delete });
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(530, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(653, 310);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // item
            // 
            item.FillWeight = 150F;
            item.HeaderText = "ITEM";
            item.MinimumWidth = 8;
            item.Name = "item";
            item.ReadOnly = true;
            item.Width = 150;
            // 
            // quantity
            // 
            quantity.FillWeight = 75F;
            quantity.HeaderText = "QUANTITY";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 150;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "TOTAL PRICE";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Width = 150;
            // 
            // delete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            delete.DefaultCellStyle = dataGridViewCellStyle1;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "DELETE";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 150;
            // 
            // checkOutButton
            // 
            checkOutButton.Location = new Point(800, 358);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(135, 40);
            checkOutButton.TabIndex = 6;
            checkOutButton.Text = "CHECK OUT";
            checkOutButton.UseVisualStyleBackColor = true;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.BackColor = SystemColors.ButtonHighlight;
            cartLabel.BorderStyle = BorderStyle.FixedSingle;
            cartLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLabel.Location = new Point(530, 12);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(159, 27);
            cartLabel.TabIndex = 7;
            cartLabel.Text = "SHOPPING CART";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1244, 715);
            Controls.Add(checkOutButton);
            Controls.Add(pictureBox1);
            Controls.Add(cartLabel);
            Controls.Add(dataGridView1);
            Controls.Add(exitButton);
            Controls.Add(calcuPanel);
            Controls.Add(fillUpPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TINDAHAN DE ALKANSE";
            Load += Form1_Load;
            fillUpPanel.ResumeLayout(false);
            fillUpPanel.PerformLayout();
            calcuPanel.ResumeLayout(false);
            calcuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemLabel;
        private Label quantityLabel;
        private Label pricePerUnitLabel;
        private Panel fillUpPanel;
        private TextBox pricePerUnitTextBox;
        private TextBox quantityTextBox;
        private TextBox itemNameTextBox;
        private Panel calcuPanel;
        private Label totalAmount;
        private Label discountAmountLabel;
        private Label discountPercentLabel;
        private Label totalCostLabel;
        private Button doneButton;
        private TextBox totalAmountTextBox;
        private TextBox discountAmountTextBox;
        private TextBox percentDiscountTextBox;
        private TextBox totalCostTextBox;
        private Button exitButton;
        private Button addButton;
        private PictureBox pictureBox1;
        private Button checkOutButton;
        private Label cartLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn delete;
    }
}
