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
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICostumerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICostumerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CostumerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CostumerAccount TGetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public List<CostumerAccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(CostumerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CostumerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
