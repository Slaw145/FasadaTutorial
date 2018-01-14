using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IBalllanceAccount
    {
        void DisplayStateAccount();
    }

    class BalllanceAccount : IBalllanceAccount
    {
        public void DisplayStateAccount()
        {
            Console.WriteLine("View account status");
        }
    }
}
