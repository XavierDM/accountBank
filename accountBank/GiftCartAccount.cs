using System;
using System.Collections.Generic;
using System.Text;

namespace accountBank
{
    public class GiftCartAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;

        public GiftCartAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        //refill with specified amount once each month last day
        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
