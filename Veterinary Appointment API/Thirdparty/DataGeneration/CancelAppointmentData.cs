using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinary_Appointment_API.WorkFolder;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public class CancelAppointmentData : IMessageData
    {
        public int MsgType { get; private set; } = 3;

        public CancelAppointmentData()
        {
            
        }

        public IEnumerable<string> Create()
        {
            Random r = new Random();
            for (int i = 1; i <= 2; i++)
            {
                string apptId = r.Next(13).ToString().PadLeft(4, '0');

                yield return $"{MsgType}{apptId}";
            }
        }
    }
}