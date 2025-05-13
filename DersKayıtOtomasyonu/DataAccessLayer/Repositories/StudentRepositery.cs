using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class StudentRepositery : IStudentDal
    {
        Context c= new Context();
        public void AddStudent(STUDENT student)
        {
           c.Add(student);
           c.SaveChanges();
        }

        public void Delete(STUDENT t)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(STUDENT student)
        {
            c.Remove(student);
            c.SaveChanges();
        }

        public STUDENT GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<STUDENT> GetListAll()
        {
            throw new NotImplementedException();
        }

        public STUDENT GeyById(int id)
        {
            return c.STUDENTS.Find(id);
        }

        public void Insert(STUDENT t)
        {
            throw new NotImplementedException();
        }

        public List<STUDENT> ListAllStuden()
        {
            return c.STUDENTS.ToList();
        }

        public void Update(STUDENT t)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(STUDENT student)
        {
            c.Update(student);
            c.SaveChanges();
        }
    }
}
