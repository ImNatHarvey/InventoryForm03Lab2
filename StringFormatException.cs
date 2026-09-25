using System;

namespace InventoryForm03Lab2
{
    class StringFormatException : Exception
    {
        public StringFormatException(string message)
            : base(message)
        {
        }
    }
}