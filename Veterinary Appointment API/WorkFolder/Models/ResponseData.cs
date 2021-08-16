using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class ResponseData
    {
        public int AppointmentID { get; set; }
        public int AppointmentTime { get; set; }
        public string CustomerName { get; set; }
        public long IdentityNumber { get; set; }

        public string PetName { get; set; }
    }
}