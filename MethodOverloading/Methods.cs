using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int j, int k)
        {
            return (j + k);
        }
        public static decimal Add(decimal j, decimal k)
        {
            return (j + k);
        }
        public static string Add(int j, int k, bool v)
        {
            var sum = j + k;
            if (v == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (v && sum == 1)
            {
                return $"{sum}dollar";
            }
            else if (v == true && sum < 1)
                return $"{sum}cents";
            else
            {
                return sum.ToString();
            }
        }
    }
}