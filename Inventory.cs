using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryForm03Lab2
{
    public partial class Inventory : Form
    {
        private string _ProductName = "";
        private string _Category = "";
        private string _MfgDate = "";
        private string _ExpDate = "";
        private string _Description = "";

        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;

        public Inventory()
        {
            InitializeComponent();

            showProductList = new BindingSource();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory =
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string item in ListOfProductCategory)
            {
                cbCategory.Items.Add(item);
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
            {
                throw new StringFormatException(
                    "Product Name should contain letters only."
                );
            }

            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
            {
                throw new NumberFormatException(
                    "Quantity should contain numbers only."
                );
            }

            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^(\d*\.?\d+)$"))
            {
                throw new CurrencyFormatException(
                    "Invalid Selling Price."
                );
            }

            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validate category selection first so we don't lose user input on error
            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show(
                    "Please select a product category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;

                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                ProductClass product = new ProductClass(
                    _ProductName,
                    _Category,
                    _MfgDate,
                    _ExpDate,
                    _SellPrice,
                    _Quantity,
                    _Description
                );

                showProductList.Add(product);

                gridViewProductList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                gridViewProductList.DataSource = null;
                gridViewProductList.DataSource = showProductList;

                txtProductName.Clear();
                txtQuantity.Clear();
                txtSellPrice.Clear();
                richTxtDescription.Clear();

                cbCategory.SelectedIndex = -1;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "String Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Number Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Currency Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}