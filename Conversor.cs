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
            if (cents.Length == 1)
            {
                string dollar = "$" + cents.Insert(0, "0");
                dollar = dollar.Insert(1, "0");
                dollar = dollar.Insert(dollar.Length-2, ".");
                return dollar;
            }
            else if (cents.Length == 2)
            {
                string dollar = "$" + cents.Insert(0, "0");
                dollar = dollar.Insert(dollar.Length - 2, ".");
                return dollar;
            }
            else
            {
                string dollar = "$" + cents.Insert(cents.Length-2, ".");
                return dollar;
            }
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
