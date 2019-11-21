using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManagement
{
    public class ViewMember
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string GENDER { get; set; }
        public string HOMETOWN { get; set; }

        public  ViewMember(PM06660 stu)
        {
            this.ID = stu.ID;
            this.CODE = stu.CODE;
            this.NAME = stu.NAME;
            this.GENDER = stu.GENDER == true ? "Nam" : "Nu";
            this.HOMETOWN = stu.HOMETOWN;
        }
    }
}
