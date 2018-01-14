using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    class ClientAPI
    {
        private IBalllanceAccount balllanceaccount;
        private IMoneySpend moneyspend;
        private IMoneyTransfer moneytransfer;

        private static Container container;

        public ClientAPI()
        {
            container = new Container();

            container.Register<IBalllanceAccount, BalllanceAccount>();
            container.Register<IMoneySpend, MoneySpend>();
            container.Register<IMoneyTransfer, MoneyTransfer>();

            ResloveMethods();
        }

        public void ResloveMethods()
        {
            balllanceaccount = container.Resolve<IBalllanceAccount>();
            moneyspend = container.Resolve<IMoneySpend>();
            moneytransfer = container.Resolve<IMoneyTransfer>();
        }

        public void Account()
        {
            balllanceaccount.DisplayStateAccount();
        }

        public void MoneySpend()
        {
            moneyspend.MoneySpendInLastMonth();
        }

        public void MoneyTransfer()
        {
            moneytransfer.MakeMoneyTransfer();
        }
    }
}
