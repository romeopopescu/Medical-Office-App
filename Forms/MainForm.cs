using Medical_Office.Classes;
using Medical_Office.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Office
{
    public partial class MainForm : Form
    {
        private Prescription Prescription {  get; set; }

        public MainForm()
        {
            Prescription = new Prescription();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            Prescription prescription = new Prescription();
            form.Prescription = prescription;
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
