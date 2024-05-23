using Medical_Office.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Office.Forms
{
    public partial class AddEditForm : Form
    {   
        //public Doctor Doctor { get; set; }
        //public Patient Patient { get; set; }   

        public Prescription Prescription { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
        }

        private void PatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
           /* if (Prescription != null)
            {
                DoctorName.Text = Prescription.Doctor.DoctorName;
                DoctorId.Value = Prescription.Doctor.DoctorId;
                PatientName.Text = Prescription.Patient.PatientName;
                PatientId.Value = Prescription.Patient.PatientId;
                Medicine.Text = Prescription.Medicine;
                DateTime.Value = Prescription.DateTime;
            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if (Prescription != null)
            //{
            //    Prescription.Doctor.DoctorName = DoctorName.Text;
            //    Prescription.Doctor.DoctorId = (int)DoctorId.Value;
            //    Prescription.Patient.PatientName = PatientName.Text;
            //    Prescription.Patient.PatientId = (int)PatientId.Value;
            //    Prescription.Medicine = Medicine.Text;
            //    Prescription.DateTime = DateTime.Value;
            //}
        }

        private void Medicine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
