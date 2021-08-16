using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Veterinary_Appointment_API.Thirdparty.Extensions
{
    public static class IdentityNumberGenerator
    {
        public static string GetIdentityNumber(this Random r)
        {
            return $"{r.Next(1111111,9999999)}{r.Next(111111, 999999)}";
        }
    }
}