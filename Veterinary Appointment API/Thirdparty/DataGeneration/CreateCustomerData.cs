using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinary_Appointment_API.Thirdparty.Extensions;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public class CreateCustomerData : IMessageData
    {
        public int MsgType { get; private set; } = 0;

        public CreateCustomerData()
        {

        }

        public IEnumerable<string> Create()
        {
            Random random = new Random();
            for (int i = 1; i <= 17; i++)
            {
                string custId = i.ToString().PadLeft(4, '0');
                string custName = random.GetCustomerName().PadLeft(24, ' ');
                string custIdentityNo = random.GetIdentityNumber();

                yield return $"{MsgType}{custId}{custName}{custIdentityNo}";
            }
        }
    }
}