using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICostumerAccountProcessService
    {
        private readonly ICostumerAccountProcessDal _costumerAccountProcessDal;

        public CustomerAccountProcessManager(ICostumerAccountProcessDal costumerAccountProcessDal)
        {
            _costumerAccountProcessDal = costumerAccountProcessDal;
        }

        public void TDelete(CostumerAccountProcess t)
        {
            _costumerAccountProcessDal.Delete(t);
        }

        public CostumerAccountProcess TGetById(int id)
        {
            return _costumerAccountProcessDal.GetById(id);
        }

        public List<CostumerAccountProcess> TGetList()
        {
            return _costumerAccountProcessDal.GetList();
        }

        public void TInsert(CostumerAccountProcess t)
        {
            _costumerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CostumerAccountProcess t)
        {
            _costumerAccountProcessDal.Update(t);
        }
    }
}
