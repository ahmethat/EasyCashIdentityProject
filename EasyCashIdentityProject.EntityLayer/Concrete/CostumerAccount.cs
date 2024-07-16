using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CostumerAccount
    {
        public int CostumerAccountID { get; set; }
        public string CostumerAccountNumber { get; set; }
        public string CostumerAccountCurrency { get; set; }
        public decimal CostumerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
