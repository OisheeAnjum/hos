using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management
{
    class appointmentDataAccess
    {
        DataAccess dataAccess;

        public appointmentDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<App> GetAllAppointment()
        {
            string sql = "SELECT * FROM appointment";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<App> apps = new List<App>();
            while (reader.Read())
            {
                App app = new App();
                //eve.date = (DateTime)reader["Date"];
                app.doctorName = reader["doctorName"].ToString();
                app.patientName = reader["patientName"].ToString();
                app.serial = (int)reader["serial"];
                app.time = reader["time"].ToString();
                app.date = reader["date"].ToString();
                //eve.theEvent = reader["Preferance"].ToString();
                apps.Add(app);
            }
            return apps;
        }

        public List<Bill> GetAllBill()
        {
            string sql = "SELECT * FROM appointment";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Bill> gab = new List<Bill>();
            while (reader.Read())
            {
                Bill bill = new Bill();
                bill.doctorName = reader["doctorName"].ToString();
                bill.patientName = reader["patientName"].ToString();
                bill.serialno = (int)reader["serial"];
                bill.fees = (int)reader["fees"];
                bill.paidAmmount = reader["paidAmmount"].ToString();
                bill.dueAmmount = reader["dueAmmount"].ToString();
                //bill.paidAmmount = (int)reader["paidAmmount"];
                //bill.dueAmmount = (int)reader["dueAmmount"];

                gab.Add(bill);
            }
            return gab;
        }


         public int UpdateBill(Bill bill)
         {
             string sql = "UPDATE appointment SET dueAmmount='" + bill.dueAmmount + "' ,paidAmmount='" + bill.paidAmmount+"' WHERE serial=" + bill.serialno;
             int result = this.dataAccess.ExecuteQuery(sql);
             return result;
         }

        public int Delete(int serial)
        {
            string sql = "DELETE FROM appointment WHERE serial=" + serial;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<Bill> GetBillInfo(string patientName)
        {
            string sql = "SELECT * FROM appointment WHERE patientName LIKE '" + patientName + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Bill> gbi = new List<Bill>();
            while (reader.Read())
            {
                Bill bill = new Bill();
                bill.doctorName = reader["doctorName"].ToString();
                bill.patientName = reader["patientName"].ToString();
                bill.serialno = (int)reader["serial"];
                bill.fees = (int)reader["fees"];
                bill.paidAmmount = reader["paidAmmount"].ToString();
                bill.dueAmmount = reader["dueAmmount"].ToString();
                //bill.paidAmmount = (int)reader["paidAmmount"];
                //bill.dueAmmount = (int)reader["dueAmmount"];

                gbi.Add(bill);
            }
            return gbi;
        }
            public List<App> GetAppBySearch(string doctorName)
        {
            string sql = "SELECT * FROM appointment WHERE doctorName LIKE '" + doctorName + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<App> appsbs = new List<App>();
            while (reader.Read())
            {
                App app = new App();
                //eve.date = (DateTime)reader["Date"];
                app.doctorName = reader["doctorName"].ToString();
                app.patientName = reader["patientName"].ToString();
                app.serial = (int)reader["serial"];
                app.time = reader["time"].ToString();
                //app.patientName = reader["Event"].ToString();
                //eve.theEvent = reader["Preferance"].ToString();
                appsbs.Add(app);
                
            }
            return appsbs;

           

            
        }
    }

}


