using System;
using System.Collections.Generic;
using System.Text;

namespace Carfacade
{
    public interface ICarModel
    {
        void SetModel();
    }

    public class CarModel : ICarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }
}
