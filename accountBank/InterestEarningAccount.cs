using System;
using System.Collections.Generic;
using System.Text;

namespace accountBank
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
            //2% credit of month-ending-balance
    }
        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}
