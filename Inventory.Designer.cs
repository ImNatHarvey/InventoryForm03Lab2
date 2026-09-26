namespace InventoryForm03Lab2
{
    partial class Inventory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblMfg = new Label();
            lblExp = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(96, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Product";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(15, 65);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(49, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 95);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // lblMfg
            // 
            lblMfg.AutoSize = true;
            lblMfg.Location = new Point(15, 125);
            lblMfg.Name = "lblMfg";
            lblMfg.Size = new Size(59, 15);
            lblMfg.TabIndex = 5;
            lblMfg.Text = "Mfg. Date";
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Location = new Point(15, 155);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(56, 15);
            lblExp.TabIndex = 7;
            lblExp.Text = "Exp. Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 185);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(29, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Qty.";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 15);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Sell Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(320, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(80, 62);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(226, 23);
            txtProductName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(80, 182);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(226, 23);
            txtQuantity.TabIndex = 10;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(80, 212);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(226, 23);
            txtSellPrice.TabIndex = 12;
            // 
            // cbCategory
            // 
            cbCategory.Location = new Point(80, 92);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(226, 23);
            cbCategory.TabIndex = 4;
            // Make the combo box non-editable so users must select from the list
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(80, 122);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(226, 23);
            dtPickerMfgDate.TabIndex = 6;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(80, 152);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(226, 23);
            dtPickerExpDate.TabIndex = 8;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(320, 85);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(452, 110);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(687, 209);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(85, 25);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(15, 252);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersVisible = false;
            gridViewProductList.Size = new Size(757, 142);
            gridViewProductList.TabIndex = 16;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 406);
            Controls.Add(lblTitle);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblCategory);
            Controls.Add(cbCategory);
            Controls.Add(lblMfg);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(lblExp);
            Controls.Add(dtPickerExpDate);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblPrice);
            Controls.Add(txtSellPrice);
            Controls.Add(lblDescription);
            Controls.Add(richTxtDescription);
            Controls.Add(btnAddProduct);
            Controls.Add(gridViewProductList);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblMfg;
        private Label lblExp;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblDescription;

        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;

        private ComboBox cbCategory;

        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;

        private RichTextBox richTxtDescription;

        private Button btnAddProduct;

        private DataGridView gridViewProductList;
    }
}