using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Office.Classes
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string PatientName {  get; set; }

        Patient() { }

        Patient(int PatientId, string PatientName)
        {
            this.PatientId = PatientId;
            this.PatientName = PatientName;
        }
        

    }
}
