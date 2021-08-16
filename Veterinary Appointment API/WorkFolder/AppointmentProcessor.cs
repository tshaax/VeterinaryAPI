using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Veterinary_Appointment_API.Thirdparty;
using Veterinary_Appointment_API.WorkFolder.BusinessRule;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder
{
    public partial class AppointmentProcessor : IAppointmentProcessor
    {
        
        /// <summary>
        /// Process_IncomingAppointment method for processing (reading, customizing and saving) the raw appointment data.
        /// </summary>
        /// <param name="rawAppointmentData">Incoming appointment data</param>
        public void Process_IncomingAppointment(string rawAppointmentData)
        {
            try
            {
                int msgType = Convert.ToInt32(rawAppointmentData.Substring(0, 1));

                switch (msgType)
                {
                    case (int)MessageTypes.createcustomer :
                        BaseLogic cuslogic = new CustomerLogic();
                        cuslogic.Process(rawAppointmentData);
                        break;

                    case (int)MessageTypes.createpet:
                        BaseLogic petlogic = new PetLogic();
                        petlogic.Process(rawAppointmentData);
                        break;

                    case (int)MessageTypes.createappointment:
                        BaseLogic applogic = new AppointmentLogic();
                        applogic.Process(rawAppointmentData);
                        break;

                    case (int)MessageTypes.cancelappointment:
                        BaseLogic canlogic = new CancelLogic();
                        canlogic.Process(rawAppointmentData);
                        break;

                    default:
                        break;
                }
   
   
            }
            catch (Exception e)
            {


            }

        }

       
    }
}