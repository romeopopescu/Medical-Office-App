using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Office.Classes
{
    internal class Prescription
    {   
        public int Id { get; set; }
        public string Medicine { get; set; }
        public DateTime DateTime { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        Prescription() { 
            
        }

        Prescription(int id, string medicine, DateTime dateTime, Patient Patient, Doctor Doctor)
        {
            Id = id;
            Medicine = medicine;
            DateTime = dateTime;
            this.Doctor = Doctor;
            this.Patient = Patient;
        }

    }
}
