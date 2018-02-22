using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedgerModel.Journal
{
    public class JournalEntry
    {
        public long ID
        {
            get;set;
        }
        public DateTime EntryDate
        {
            get;set;
        }
        public string Explanation
        {
            get;set;
        }
        public JournalTypes JournalType
        {
            get;set;
        }
        public ICollection<JournalTransaction> JournalTransactions
        {
            get;
            set;
        }

        public decimal Balance
        {
            get
            {
                decimal debits = 0;
                decimal credits = 0;
                if (JournalTransactions == null || JournalTransactions.Count <= 0)
                    return 0;
                foreach(JournalTransaction jt in JournalTransactions)
                {
                    debits += jt.Debit;
                    credits += jt.Credit;
                }
                return debits - credits;
            }
        }

    }
}
