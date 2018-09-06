using BackEnd.DAL;
using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BLL
{
    [DataObject]
    public class StudentController 
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
