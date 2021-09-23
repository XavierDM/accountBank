using System;
using System.Collections.Generic;
using System.Text;

namespace accountBank
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
            //neg balance
            //if balance < 0 => interest rate
            //over limit => additional fee
        }
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                var interest = Balance * 0.07m;
                MakeDeposit(interest, DateTime.Now, "charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        isOverdrawn
            ? new Transaction(-20, DateTime.Now, "apply overdraft fee")
            : default;
    }
}
