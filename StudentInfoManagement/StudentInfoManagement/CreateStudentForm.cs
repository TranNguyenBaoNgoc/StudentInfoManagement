using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoManagement
{
    public partial class CreateStudentForm : Form
    {
        private StudentManagement Business;
        public CreateStudentForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var gender = true;
            if (raBtnFemale.Checked ==true)
	        {
                gender = false;
	        }
            var hometown = this.txtHometown.Text;
            this.Business.CreateStudent(code, name, gender, hometown);
            MessageBox.Show("Create successfuly");
            this.Close();
        }
    }
}
