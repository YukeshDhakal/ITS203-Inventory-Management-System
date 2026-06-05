using System;

namespace SmartInventorySystem
{
    /// <summary>
    /// ABSTRACTION: Abstract base class that cannot be instantiated directly
    /// Demonstrates OOP Principle: Abstraction
    /// </summary>
    public abstract class InventoryItem
    {
        // ENCAPSULATION: Private fields with public properties
        private string _itemCode;
        private string _name;
        private int _quantity;
        private decimal _price;

        // Properties with validation logic (ENCAPSULATION)
        public string ItemCode
        {
            get => _itemCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Item code cannot be empty.");
                _itemCode = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Item name cannot be empty.");
                _name = value;
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                _quantity = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        public int LowStockThreshold { get; set; } = 5; // Default value

        // Constructor
        protected InventoryItem(string itemCode, string name, int quantity, decimal price, int lowStockThreshold)
        {
            ItemCode = itemCode;
            Name = name;
            Quantity = quantity;
            Price = price;
            LowStockThreshold = lowStockThreshold;
        }

        // POLYMORPHISM: Virtual method - can be overridden by derived classes
        public virtual string GetDetails()
        {
            return $"[{ItemCode}] {Name} | Qty: {Quantity} | Price: ${Price:F2}";
        }

        // Business logic method
        public bool IsLowStock()
        {
            return Quantity <= LowStockThreshold;
        }

        // For displaying in ListBox
        public override string ToString()
        {
            return GetDetails();
        }
    }
}