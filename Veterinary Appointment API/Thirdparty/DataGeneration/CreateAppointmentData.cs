using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public class CreateAppointmentData : IMessageData
    {
        public int MsgType { get; private set; } = 2;
        private readonly List<string> _timeSlots = new List<string>();

        public CreateAppointmentData()
        {
            _timeSlots.Add("0900");
            _timeSlots.Add("0930");
            _timeSlots.Add("1000");
            _timeSlots.Add("1030");
            _timeSlots.Add("1100");
            _timeSlots.Add("1130");
            _timeSlots.Add("1200");
            _timeSlots.Add("1230");
            _timeSlots.Add("1300");
            _timeSlots.Add("1330");
            _timeSlots.Add("1400");
            _timeSlots.Add("1430");
            _timeSlots.Add("1500");
            _timeSlots.Add("1530");
            _timeSlots.Add("1600");
            _timeSlots.Add("1630");
            _timeSlots.Add("1700");
        }

        private string GetAppointmentTimeSlot(Random r)
        {
            int index = r.Next(_timeSlots.Count);

            string data = _timeSlots[index];
            _timeSlots.Remove(_timeSlots[index]);

            return data;
        }


        public IEnumerable<string> Create()
        {
            string apptId = string.Empty;
            string custId = string.Empty;
            string petId;
            string time = string.Empty;

            Random r = new Random();
            for (int i = 1; i <= 18; i++)
            {
                if (i != 17)
                {
                    apptId = i.ToString().PadLeft(4, '0');

                    custId = i != 18 ? i.ToString().PadLeft(4, '0') : "0000";
                }

                petId = i.ToString().PadLeft(4, '0');

                //Same appointment so use previous time slot if i == 15 | 17
                if (i != 15 && i != 17)
                {
                    time = GetAppointmentTimeSlot(r);
                }

                yield return $"{MsgType}{apptId}{custId}{petId}{time}";
            }

            //cust without pet
            apptId = 19.ToString().PadLeft(4, '0');
            custId = 17.ToString().PadLeft(4, '0');
            petId = "0000";
            time = "1000";

            yield return $"{MsgType}{apptId}{custId}{petId}{time}";
        }
    }
}