using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using Veterinary_Appointment_API.Thirdparty.Database;
using Veterinary_Appointment_API.Thirdparty.DataGeneration;
using Veterinary_Appointment_API.Thirdparty.Extensions;
using Veterinary_Appointment_API.WorkFolder;

namespace Veterinary_Appointment_API.Thirdparty
{
    public sealed class AppointmentGenerator
    {
        private delegate void ProcessAppointmentDelegate(string rawData);
        private event ProcessAppointmentDelegate OnIncomingAppointment;

        private readonly Timer _eventTimer = new Timer();
        private MessageDataEngine _messageDataEngine = new MessageDataEngine();

        public AppointmentGenerator()
        {
            DataManager.Startup();

            OnIncomingAppointment +=  new AppointmentProcessor().Process_IncomingAppointment;

            _eventTimer.Interval = 2000;
            _eventTimer.Elapsed += (sender, args) =>  Run();
            _eventTimer.Start();
        }

        private async Task Run()
        {
            try
            {
                OnIncomingAppointment?.Invoke(_messageDataEngine.RetrieveData());
            }
            catch (Exception e)
            {
                _eventTimer.Stop();
                _eventTimer.Dispose();
                _messageDataEngine.Dispose();
            }
        }
    }
}