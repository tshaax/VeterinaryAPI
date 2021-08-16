using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinary_Appointment_API.Thirdparty.Extensions;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public class CreatePetData : IMessageData
    {
        public int MsgType { get; private set; } = 1;

        public CreatePetData()
        {

        }

        public IEnumerable<string> Create()
        {
            Random random = new Random();

            for (int i = 1; i <= 18; i++)
            {
                string petId = i.ToString().PadLeft(4, '0');

                string custId = i.ToString().PadLeft(4, '0');

                if (i == 17)
                    custId = (i - 1).ToString().PadLeft(4, '0');
                if (i == 18)
                    custId = "0000";

                string petName = random.GetPetName().PadLeft(11, ' ');

                yield return $"{MsgType}{petId}{custId}{petName}";
            }
        }
    }
}