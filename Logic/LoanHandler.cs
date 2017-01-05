using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class LoanHandler
    {
        Data.IDBAccess db = Data.DBAccessFactory.getDBAccess();

        public Data.Loan getLoan(int loan_id)
        {
            return db.getLoan(loan_id);
        }

        public void setLoan(Data.Loan loan)
        {
            db.setLoan(loan);
        }
    }
}