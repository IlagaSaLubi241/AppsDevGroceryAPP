namespace GroceryApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            totalCostLabel = new Label();
            percentDiscountLabel = new Label();
            discountAmountLabel = new Label();
            finalAmountLabel = new Label();
            receiptDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            discountPercentLabel = new Label();
            label2 = new Label();
            totalAmount = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)receiptDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalCostLabel.ForeColor = SystemColors.ControlLightLight;
            totalCostLabel.Location = new Point(400, 539);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(69, 20);
            totalCostLabel.TabIndex = 1;
            totalCostLabel.Text = "label1";
            totalCostLabel.Click += totalCostLabel_Click;
            // 
            // percentDiscountLabel
            // 
            percentDiscountLabel.AutoSize = true;
            percentDiscountLabel.Font = new Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentDiscountLabel.ForeColor = SystemColors.ControlLightLight;
            percentDiscountLabel.Location = new Point(400, 561);
            percentDiscountLabel.Name = "percentDiscountLabel";
            percentDiscountLabel.Size = new Size(69, 20);
            percentDiscountLabel.TabIndex = 2;
            percentDiscountLabel.Text = "label2";
            percentDiscountLabel.Click += percentDiscountLabel_Click;
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountAmountLabel.ForeColor = SystemColors.ControlLightLight;
            discountAmountLabel.Location = new Point(400, 586);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(69, 20);
            discountAmountLabel.TabIndex = 3;
            discountAmountLabel.Text = "label3";
            discountAmountLabel.Click += discountAmountLabel_Click;
            // 
            // finalAmountLabel
            // 
            finalAmountLabel.AutoSize = true;
            finalAmountLabel.Font = new Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalAmountLabel.ForeColor = SystemColors.ControlLightLight;
            finalAmountLabel.Location = new Point(400, 638);
            finalAmountLabel.Name = "finalAmountLabel";
            finalAmountLabel.Size = new Size(69, 20);
            finalAmountLabel.TabIndex = 4;
            finalAmountLabel.Text = "label4";
            finalAmountLabel.Click += finalAmountLabel_Click;
            // 
            // receiptDataGridView
            // 
            receiptDataGridView.BackgroundColor = SystemColors.Control;
            receiptDataGridView.BorderStyle = BorderStyle.Fixed3D;
            receiptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receiptDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            receiptDataGridView.Location = new Point(12, 12);
            receiptDataGridView.Name = "receiptDataGridView";
            receiptDataGridView.RowHeadersWidth = 62;
            receiptDataGridView.Size = new Size(532, 515);
            receiptDataGridView.TabIndex = 5;
            receiptDataGridView.CellContentClick += receiptDataGridView_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ITEM";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "QUANTITY";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "PRICE";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(271, 536);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 9;
            label1.Text = "TOTAL COST:";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentLabel.ForeColor = SystemColors.ControlLightLight;
            discountPercentLabel.Location = new Point(201, 558);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new Size(193, 25);
            discountPercentLabel.TabIndex = 10;
            discountPercentLabel.Text = "PERCENT DISCOUNT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(198, 583);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 11;
            label2.Text = "DISCOUNT AMOUNT:";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.ForeColor = SystemColors.ControlLight;
            totalAmount.Location = new Point(235, 635);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(159, 25);
            totalAmount.TabIndex = 12;
            totalAmount.Text = "TOTAL AMOUNT:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 536);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 126);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(559, 671);
            Controls.Add(pictureBox1);
            Controls.Add(totalAmount);
            Controls.Add(label2);
            Controls.Add(discountPercentLabel);
            Controls.Add(label1);
            Controls.Add(receiptDataGridView);
            Controls.Add(finalAmountLabel);
            Controls.Add(discountAmountLabel);
            Controls.Add(percentDiscountLabel);
            Controls.Add(totalCostLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)receiptDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalCostLabel;
        private Label percentDiscountLabel;
        private Label discountAmountLabel;
        private Label finalAmountLabel;
        private DataGridView receiptDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private Label discountPercentLabel;
        private Label label2;
        private Label totalAmount;
        private PictureBox pictureBox1;
    }
}