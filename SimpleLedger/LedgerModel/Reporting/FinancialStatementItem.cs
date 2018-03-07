using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedgerModel.Ledger.Reporting
{

    public class FinancialStatementItem
    {
        public int ID
        {
            get;set;
        }

        /// <summary>
        /// The order to display this item in the financial statement
        /// </summary>
        public int DisplayIndex
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public ICollection<LedgerAccount> Accounts
        {
            get;set;
        }

        /// <summary>
        /// if is set to true the this item will have sub total in the statement..
        /// for example 
        /// Total Current Assets.....................................15045555.55
        /// </summary>
        public bool DisplaySubTotal
        {
            get;set;
        }

        /// <summary>
        /// If this item has many accounts and this property is set to false 
        /// the accounts will not be displayed in the statement.
        /// </summary>
        public bool DisplayAccounts
        {
            get;set;
        }

        /// <summary>
        /// The financial statement this item belongs to.
        /// </summary>
        public FinancialStatement Statement
        {
            get;set;
        }

        /// <summary>
        /// 
        /// The root item of this item.
        /// </summary>
        public FinancialStatementItem ParentItem
        {
            get;set;
        }

        /// <summary>
        /// The children items of this item.
        /// </summary>
        public ICollection<FinancialStatementItem> SubItems
        {
            get;set;
        }
    }
}
