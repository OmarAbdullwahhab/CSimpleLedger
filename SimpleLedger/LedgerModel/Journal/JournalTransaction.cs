using LedgerModel.Ledger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedgerModel.Journal
{
    public class JournalTransaction
    {
        public long ID
        {
            get;set;
        }

        public LedgerAccount Account
        {
            get;set;
        }

        public decimal Debit
        {
            get;set;
        }

        public decimal Credit
        {
            get;set;

        }

        public string Explanation
        {
            get;set;
        }

        public DocumentType DocumentType
        {
            get;set;
        }

        public string DocumentNumber
        {
            get;set;
        }

        public JournalEntry JournalEntry
        {
            get;set;
        }
    }
}
