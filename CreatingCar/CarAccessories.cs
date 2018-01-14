using System;
using System.Collections.Generic;
using System.Text;

namespace Carfacade
{
    public interface ICarAccessories
    {
        void SetAccessories();
    }

    public class CarAccessories : ICarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }
}
