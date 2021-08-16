using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.BusinessRule
{
    public abstract class BaseLogic
    {
        public abstract void Process(string rawAppointmentData);
    }
}