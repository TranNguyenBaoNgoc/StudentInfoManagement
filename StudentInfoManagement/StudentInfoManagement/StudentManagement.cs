using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManagement
{
    public class StudentManagement
    {
        public PM06660[] GetStudents()
        {
            var db = new OOPCSEntities();
            return db.PM06660.ToArray();
        }
        public PM06660 GetStudent(int id)
        {
            var db = new OOPCSEntities();
            return db.PM06660.Find(id);
        }
        public void CreateStudent(string code, string name, bool gender, string hometown)
        {
            var newStudent = new PM06660();
            newStudent.CODE = code;
            newStudent.NAME = name;
            newStudent.GENDER = gender;
            newStudent.HOMETOWN = hometown;

            var db = new OOPCSEntities();
            db.PM06660.Add(newStudent);
            db.SaveChanges();
        }
        public void UpdateStudent(int id, string code, string name, bool gender, string hometown)
        {
            var db = new OOPCSEntities();
            var oldStudent = db.PM06660.Find(id);

            oldStudent.CODE = code;
            oldStudent.NAME = name;
            oldStudent.GENDER = gender;
            oldStudent.HOMETOWN = hometown;
            db.Entry(oldStudent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteClass(int id)
        {
            var db = new OOPCSEntities();
            var student = db.PM06660.Find(id);
            db.PM06660.Remove(student);
            db.SaveChanges();
        }
        
    }
}
