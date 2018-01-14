using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IMoneySpend
    {
        void MoneySpendInLastMonth();
    }

    class MoneySpend : IMoneySpend
    {
        public void MoneySpendInLastMonth()
        {
            Console.WriteLine("View the amount of money spent in the last month");
        }
    }
}
