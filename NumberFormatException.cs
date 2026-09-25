using System;

namespace InventoryForm03Lab2
{
    class NumberFormatException : Exception
    {
        public NumberFormatException(string message)
            : base(message)
        {
        }
    }
}