using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding.Binders;
using Veterinary_Appointment_API.Thirdparty.Database;

namespace Veterinary_Appointment_API.WorkFolder.Data_Services
{
    public class ExampleService : DataManager
    {
        public void SaveExample()
        {
            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Example(Column1 int, Column2 varchar(50))";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO Example SELECT 1, 'ExampleValue'";
                command.ExecuteNonQuery();
            }
        }

        public string ReturnExampleValue()
        {
            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT Column2 FROM Example";
                return command.ExecuteScalar().ToString();
            }
        }

    }
}