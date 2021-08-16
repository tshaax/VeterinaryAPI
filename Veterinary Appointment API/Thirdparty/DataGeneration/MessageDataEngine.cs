using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebGrease.Css.Extensions;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public class MessageDataEngine : IDisposable
    {
        private List<string> RawDataList { get; set; } = new List<string>();

        public MessageDataEngine()
        {
            Run(new CancelAppointmentData());
            Run(new CreateAppointmentData());
            Run(new CreateCustomerData());
            Run(new CreatePetData());
        }

        private void Run(IMessageData messageData)
        {
            messageData.Create().ForEach(i => RawDataList.Add(i));
        }


        public string RetrieveData()
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(RawDataList.Count);

            string data = RawDataList[index];
            RawDataList.Remove(RawDataList[index]);

            return data;
        }

        public void Dispose()
        {
            RawDataList.Clear();
        }
    }
}