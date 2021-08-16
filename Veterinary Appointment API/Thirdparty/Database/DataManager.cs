using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.Thirdparty.Database
{
    public class DataManager : IDisposable
    {
        public SQLiteConnection Connection { get; private set; }

        public DataManager()
        {
            try
            {
                string database = $"{AppDomain.CurrentDomain.BaseDirectory}\\Thirdparty\\Database\\Veterinary.sqlite";

                Connection = new SQLiteConnection($"Data Source={database}");
                Connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Startup()
        {
            string database = $"{AppDomain.CurrentDomain.BaseDirectory}\\Thirdparty\\Database\\Veterinary.sqlite";

            if (File.Exists(database))
                File.Delete(database);
            else
                SQLiteConnection.CreateFile(database);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}