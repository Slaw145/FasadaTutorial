using System;
using System.Collections.Generic;
using System.Text;

namespace Carfacade
{
    public interface ICarEngine
    {
        void SetEngine();
    }

    public class CarEngine : ICarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }
}
