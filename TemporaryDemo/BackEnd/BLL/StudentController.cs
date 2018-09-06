using BackEnd.DAL;
using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BLL
{
    public class StudentController 
    {
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
