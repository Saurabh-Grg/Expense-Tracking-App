using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pennywise.Components.Models
{
    public class Transaction
    {
        public string Id { get; set; } // Unique identifier for the transaction
        public string UserId { get; set; } // User ID to associate the transaction with a user
        public string Title { get; set; } // Title of the transaction
        public decimal Amount { get; set; } // Amount of money for the transaction
        public string Type { get; set; } // Type of transaction (e.g., Income, Expense)
        public DateTime Date { get; set; } // Date of the transaction
        public string Category { get; set; } // Category of the transaction (e.g., Groceries, Rent)
        public string Tags { get; set; } // List of tags to categorize the transaction
        public string Notes { get; set; } // Notes related to the transaction (optional)

        // New property to store total amount (income - expense)
        public decimal TotalAmount { get; set; }
    }
}

