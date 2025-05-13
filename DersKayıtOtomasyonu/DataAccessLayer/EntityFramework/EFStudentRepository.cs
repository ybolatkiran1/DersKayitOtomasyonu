using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFStudentRepository : GenericRepository<STUDENT>, IStudentDal
    {
        //    public STUDENT GetById(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public List<STUDENT> GetListAll()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Insert(STUDENT student)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Remove(STUDENT student)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Update(STUDENT student)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
