using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Veterinary_Appointment_API.Thirdparty.Database;
using Veterinary_Appointment_API.WorkFolder.Models;

namespace Veterinary_Appointment_API.WorkFolder.Data_Services
{
    public class DbService : DataManager  
    {
        public void Save(string createtb, string insertData)
        {
            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = createtb; 
                command.ExecuteNonQueryAsync();

                command.CommandText = insertData;
                command.ExecuteNonQueryAsync();        
            }
        }

        public List<ResponseData> GetAppointmentDbData()
        {
            using (SQLiteCommand command = Connection.CreateCommand())
            {
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append(" SELECT a.appt_id as 'AppointmentID', appt_time as 'AppointmentTime',c.cust_name as 'CustomerName',");
                strSQL.Append(" c.cust_identity_num as 'IdentityNumber', p.pet_name as 'PetName'");
                strSQL.Append(" FROM Appointment a INNER JOIN Customer c on c.cust_id = a.cust_id");
                strSQL.Append(" INNER JOIN Pet p on p.cust_id");
                command.CommandText = strSQL.ToString();
                var res = command.ExecuteReader();

                var list = new List<ResponseData>();
                while (res.Read())
                {
                    list.Add(new ResponseData
                    {
                        AppointmentID = Convert.ToInt32(res["AppointmentID"]),
                        AppointmentTime = Convert.ToInt32(res["AppointmentTime"]),
                        CustomerName = (string)res["CustomerName"],
                        IdentityNumber = Convert.ToInt64(res["IdentityNumber"]),
                        PetName = (string)res["PetName"],

                    });
                    
                }

                return list;
            }
        }
    }
}