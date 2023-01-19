using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToCents
{
    public static class Conversor
    {
        public static string ToDollar(string cents)
        {
            string dollar = "$" + cents.Insert(cents.Length-2, ".");
            return dollar;
        }
        
        public static string ToCents(string value)
        {
            string dollarsFormat = value.Replace("$", "");
            string dollars = dollarsFormat.Replace(".", "");
            string cents = dollars;
            return cents;
        }
    }
}
