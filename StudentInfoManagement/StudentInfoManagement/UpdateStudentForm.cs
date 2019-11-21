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
    public partial class UpdateStudentForm : Form
    {
        private StudentManagement Business;
        private int Student_Id;
        public UpdateStudentForm(int id)
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.Student_Id = id;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateStudentForm_Load;
        }

        void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudent(this.Student_Id);
            this.txtCode.Text = student.CODE;
            this.txtName.Text = student.NAME;
            this.raBtnFemale.Checked = true;
            if (student.GENDER == true)
            {
                this.raBtnMale.Checked = true;
            }
            this.txtHometown.Text = student.HOMETOWN;
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
            if (raBtnFemale.Checked == true)
            {
                gender = false;
            }
            var hometown = this.txtHometown.Text;
            this.Business.UpdateStudent(this.Student_Id, code, name, gender, hometown);
            MessageBox.Show("Update class successfuly");
            this.Close();
        }
    }
}
