using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedgerModel.Ledger
{
    public class LedgerAccount
    {
        public int ID
        {
            get;set;
        }

        public int AccountNumber
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public AccountTypes AccountType
        {
            get;set;
        }

        public NormalBalance NormalBalance
        {
            get;set;
        }
    }
}
