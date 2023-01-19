using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToCents
{
    public static class Conversor
    {
        public static string ToDollar(int cents)
        {
            string centsString = cents.ToString();
            string dollar = "$" + centsString.Insert(centsString.Length-2, ".");
            return dollar;
        }
        
        public static int ToCents(string value)
        {
            string dollarsFormat = value.Replace("$", "");
            string dollars = dollarsFormat.Replace(".", "");
            int cents = Convert.ToInt32(dollars);
            return cents;
        }
    }
}
