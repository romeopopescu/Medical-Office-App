using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Office.Classes
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set;}
        

        public Doctor() { }

        public Doctor(int DoctorId, string DoctorName)
        {
            this.DoctorId = DoctorId;
            this.DoctorName = DoctorName;
            
        }
    }
}
