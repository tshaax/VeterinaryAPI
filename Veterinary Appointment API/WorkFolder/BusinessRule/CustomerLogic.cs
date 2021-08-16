using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder.BusinessRule
{
    public class CustomerLogic : BaseLogic
    {
        private readonly DbService db;

        public CustomerLogic()
        {
            this.db = new DbService();
        }
        public override void Process(string rawAppointmentData)
        {

            var obj = new Models.CustomerDto
            {
                msg_type = Convert.ToInt32(rawAppointmentData.Substring(0, 1)),
                cust_id = Convert.ToInt32(rawAppointmentData.Substring(1, 4)),
                cust_name = rawAppointmentData.Substring(5, 24),
                cust_identity_num = Convert.ToInt64(rawAppointmentData.Substring(29, 13))

            };

            StringBuilder createtb = new StringBuilder
                ($"CREATE TABLE IF NOT EXISTS Customer (msg_type int, cust_id int, cust_name varchar(50), cust_identity_num int)");

            StringBuilder insertdt = new StringBuilder();
            insertdt.Append(" INSERT INTO Customer (msg_type,cust_id,cust_name,cust_identity_num)");
            insertdt.Append($" VALUES ({obj.msg_type},{obj.cust_id},'{obj.cust_name}',{obj.cust_identity_num})");

            db.Save(createtb.ToString(), insertdt.ToString());
        }
    }
}