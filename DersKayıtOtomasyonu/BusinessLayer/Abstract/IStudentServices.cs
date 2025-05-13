using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentServices
    {
        void StudentAdd(STUDENT student);
        void StudentDelete(STUDENT student);
        void StudentUpdate(STUDENT student);
        List<STUDENT> GetList();
        STUDENT GetById(int id);
        
    }
}
