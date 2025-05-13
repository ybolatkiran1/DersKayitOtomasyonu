using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentServices
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public STUDENT GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public List<STUDENT> GetList()
        {
            return _studentDal.GetListAll();
        }

        public void StudentAdd(STUDENT student)
        {
            _studentDal.Insert(student);
        }

        public void StudentDelete(STUDENT student)
        {
            _studentDal.Delete(student);
            
        }

        public void StudentUpdate(STUDENT student)
        {
            _studentDal.Update(student);
        }
    }
}
