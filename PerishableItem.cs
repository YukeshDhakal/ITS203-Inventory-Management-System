using System;

namespace SmartInventorySystem
{
    /// <summary>
    /// INHERITANCE: PerishableItem inherits from InventoryItem
    /// Demonstrates OOP Principle: Inheritance
    /// </summary>
    public class PerishableItem : InventoryItem
    {
        // Additional property specific to perishable items
        public DateTime ExpirationDate { get; set; }

        // Constructor calling base class constructor
        public PerishableItem(string itemCode, string name, int quantity, decimal price, int lowStockThreshold, DateTime expirationDate)
            : base(itemCode, name, quantity, price, lowStockThreshold)
        {
            ExpirationDate = expirationDate;
        }

        // POLYMORPHISM: Overriding the base method
        public override string GetDetails()
        {
            return $"{base.GetDetails()} | Expires: {ExpirationDate:yyyy-MM-dd}";
        }

        // Check if item is expired
        public bool IsExpired()
        {
            return ExpirationDate.Date < DateTime.Now.Date;
        }

        // Additional method for expiry alert
        public bool IsNearExpiry(int daysThreshold = 7)
        {
            return (ExpirationDate.Date - DateTime.Now.Date).Days <= daysThreshold;
        }
    }
}