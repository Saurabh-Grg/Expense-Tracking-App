using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pennywise.Components.Models
{
    public class Debt
    {
        public string Id { get; set; } // Unique identifier for the transaction
        public string UserId { get; set; } // User ID to associate the transaction with a user
        public string Title { get; set; } // Title of the transaction
        public decimal Amount { get; set; } // Amount of money for the transaction
        public DateTime Date { get; set; } // Date of the transaction
        public string Status { get; set; }
        public string Source { get; set; }    // Where the debt is from
        public DateTime DueDate { get; set; }
        public bool IsCleared { get; set; } = false; // Has the debt been cleared?
        public string Notes { get; set; } // Notes related to the transaction (optional)
    }
}
