using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management
{
    class service
    {

        appointmentDataAccess ada;
        public service()
        {
            this.ada = new appointmentDataAccess();
        }

        public List<App> GetListOfAppointment()
        {
            return this.ada.GetAllAppointment();
        }
        public List<Bill> GetListOfBill()
        {
            return this.ada.GetAllBill();
        }


        public int UpdateBill(int serial,string dueAmmount, string paidAmmount)
        {
            Bill bill = new Bill()
            {
                serialno = serial,
                dueAmmount =dueAmmount,
                paidAmmount =paidAmmount
            };
            return this.ada.UpdateBill(bill);

        }
        public int Delete(string id)
        {
            return this.ada.Delete(Convert.ToInt32(id));
        }
        public List<App> GetAppListBySearch(string doctorName)
        {
            return ada.GetAppBySearch(doctorName);
        }
        public List<Bill> Getlistofbill(string patientName)
        {
            return this.ada.GetBillInfo(patientName);
        }

    }
}

