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
    public partial class IndexStudentForm : Form
    {
        private StudentManagement Business;
        public IndexStudentForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.Load += IndexStudentForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdStudent.DoubleClick += grdStudent_DoubleClick;
        }

        void grdStudent_DoubleClick(object sender, EventArgs e)
        {
            var stu = (PM06660)this.grdStudent.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateStudentForm(stu.ID);
            updateForm.ShowDialog();
            this.LoadAllStudents();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.grdStudent.SelectedRows.Count==1)
           {
               if (MessageBox.Show("Do you want to delete this?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) ;
               {
                   var stu = (PM06660)this.grdStudent.SelectedRows[0].DataBoundItem;
                   this.Business.DeleteClass(stu.ID);
                   MessageBox.Show("Delete successfuly");
                   this.LoadAllStudents();
               }
           }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new CreateStudentForm();
            createForm.ShowDialog();
            this.LoadAllStudents();
        }

        void IndexStudentForm_Load(object sender, EventArgs e)
        {
            this.LoadAllStudents();
        }
        private void LoadAllStudents()
        {
            var students = this.Business.GetStudents();
            this.grdStudent.DataSource = students;
        }
    }
}
