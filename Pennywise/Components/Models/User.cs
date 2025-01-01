using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pennywise.Components.Models
{
    public class User
    {
        public string UserId { get; set; } // Added UserId
        public string Username { get; set; }
        public string Password { get; set; }
        public string PreferredCurrency { get; set; }
    }
}
