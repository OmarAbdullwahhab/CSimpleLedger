using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedgerModel.Ledger.Reporting
{
    /// <summary>
    /// This class is used to represent a  user defined financial statement instead 
    /// of defining it statically
    /// </summary>
    public class FinancialStatement
    {
        public int ID
        {
            get;set;
        }

        /// <summary>
        /// The title that will be displayed in the financial statement
        /// for extample
        /// 
        ///                                Company Name Here
        ///                                  Balance Sheet
        ///                                December 31, 2010
        /// or
        ///                                Company Name Here
        ///                                 Income Statement 
        ///                        for the year ended December 31, 2017
        /// 
        /// </summary>
        public string Title
        {
            get;set;
        }

        public ICollection<FinancialStatementItem> StatementItems
        {
            get;set;
        }

    }
}
