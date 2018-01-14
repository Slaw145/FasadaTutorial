using System;
using System.Collections.Generic;

namespace Fasada
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientAPI clientapi = new ClientAPI();

            clientapi.MoneySpend();
            clientapi.MoneyTransfer();
            clientapi.Account();

            Console.ReadKey();
        }
    }
}
