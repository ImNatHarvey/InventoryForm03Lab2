namespace InventoryForm03Lab2
{
    class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName;
        private string _Category;
        private string _ManufacturingDate;
        private string _ExpirationDate;
        private string _Description;

        public ProductClass(
            string ProductName,
            string Category,
            string MfgDate,
            string ExpDate,
            double Price,
            int Quantity,
            string Description)
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }

        public string productName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public string category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        public string manufacturingDate
        {
            get { return _ManufacturingDate; }
            set { _ManufacturingDate = value; }
        }

        public string expirationDate
        {
            get { return _ExpirationDate; }
            set { _ExpirationDate = value; }
        }

        public string description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public double sellingPrice
        {
            get { return _SellingPrice; }
            set { _SellingPrice = value; }
        }
    }
}