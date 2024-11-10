using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context):base(context) { }

        public void Delete(EntityLayer.Concrete.Process t)
        {
            throw new NotImplementedException();
        }

        public void Insert(EntityLayer.Concrete.Process t)
        {
            throw new NotImplementedException();
        }

        public void MultiUpdate(List<EntityLayer.Concrete.Process> t)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityLayer.Concrete.Process t)
        {
            throw new NotImplementedException();
        }

        public void GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void GetList()
        {
            throw new NotImplementedException();
        }

        List<EntityLayer.Concrete.Process> IGenericDal<EntityLayer.Concrete.Process>.GetList()
        {
            throw new NotImplementedException();
        }

        EntityLayer.Concrete.Process IGenericDal<EntityLayer.Concrete.Process>.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
