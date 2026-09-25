using System;

namespace InventoryForm03Lab2
{
    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message)
            : base(message)
        {
        }
    }
}