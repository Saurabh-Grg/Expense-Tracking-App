using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using Pennywise.Components.Models;

namespace Pennywise.Components.Helpers
{
    public static class UserStorage
    {
        private static string FilePath = Path.Combine(AppContext.BaseDirectory, "Components", "Data", "user.json");

        public static User LoadUser()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);

                return JsonSerializer.Deserialize<User>(json);
            }
            return null;
        }
    }
}
