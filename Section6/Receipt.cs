using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Receipt
    {
        //Variables
        private int receiptNumber;
        private int customerNumber;
        private int itemNumber;
        private decimal unitPrice;
        private int quantityPurchased;

        //Properties
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                    receiptNumber = value;
            }
        }
        public string DateOfPurchase { get; set; }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                    customerNumber = value;
            }
        }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value <= 9999)
                    itemNumber = value;
            }
        }
        public string Description { get; set; }
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value <= 9999)
                    unitPrice = value;
            }
        }
        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0)
                    quantityPurchased = value;
            }
        }

        //Constructors
        public Receipt(int receiptNumber, string dateOfPurchase, int customerNumber, string customerName, string customerAddress,
                       string customerPhoneNumber, int itemNumber, string description, decimal unitPrice, int quantityPurchased)
        {
            ReceiptNumber = receiptNumber;
            DateOfPurchase = dateOfPurchase;
            CustomerNumber = customerNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerPhoneNumber = customerPhoneNumber;
            ItemNumber = itemNumber;
            Description = description;
            UnitPrice = unitPrice;
            QuantityPurchased = quantityPurchased;
        }

        //Methods
        public decimal CalculateTotalCost()
        {
            return UnitPrice * QuantityPurchased;
        }

        public override string ToString()
        {
            return $"Customer: {CustomerName}" +
                $"\nPhone: {CustomerPhoneNumber}" +
                $"\nTotal Purchases: {CalculateTotalCost().ToString("c")}";
        }
    }
}
