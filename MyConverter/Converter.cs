using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConverter
{
    internal class Converter
    {
        public const decimal DollarRate = 41.2072m;
        public const decimal EuroRate = 45.0477m;

        public decimal ConvertToDollars(decimal amountInHryvnia)
        {
            return amountInHryvnia / DollarRate;
        }

        public decimal ConvertToEuros(decimal amountInHryvnia)
        {
            return amountInHryvnia / EuroRate;
        }

        public decimal ConvertFromDollars(decimal amountInDollars)
        {
            return amountInDollars * DollarRate;
        }

        public decimal ConvertFromEuros(decimal amountInEuros)
        {
            return amountInEuros * EuroRate;
        }
    }
}
