using System;
using System.Collections.Generic;
using System.Text;

namespace Carfacade
{
    public interface ICarBody
    {
        void SetBody();
    }

    public class CarBody : ICarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }
}
