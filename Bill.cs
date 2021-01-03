using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management
{
    class Bill
    {
        public int serialno { get; set; }
        public int fees { get; set; }
        public string paidAmmount { get; set; }
        public string dueAmmount { get; set; }
        public string patientName { get; set; }

        public string doctorName { get; set; }
        //public string date { get; set; }
    }
}
