using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class CustomerDto
    {
        public int msg_type { get; set; }
        public int cust_id { get; set; }
        public string cust_name { get; set; }
        public long cust_identity_num { get; set; }
    }
}