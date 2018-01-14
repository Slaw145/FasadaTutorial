using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IMoneyTransfer
    {
        void MakeMoneyTransfer();
    }

    class MoneyTransfer : IMoneyTransfer
    {
        public void MakeMoneyTransfer()
        {
            Console.WriteLine("Make a transfer");
        }
    }
}
