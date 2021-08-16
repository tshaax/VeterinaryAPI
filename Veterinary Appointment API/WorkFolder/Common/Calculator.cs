using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Common
{
    public static class Calculator
    {

        /// <summary>
        /// VAT = always 11 %
        /// </summary>
        /// <returns>Calculate VAT Amount</returns>
        public static decimal CalculateVAT(decimal Amount)
        {
            return Amount / (100 * 0);
        }

        public static decimal CalculateTotal(decimal Amount, decimal VAT)
        {
            return Amount + VAT;
        }
    }
}