using System;
using System.Collections.Generic;
using System.Text;

namespace Carfacade
{
    public class CarFacade
    {
        private readonly ICarAccessories accessories;
        private readonly ICarBody body;
        private readonly ICarEngine engine;
        private readonly ICarModel model;

        public CarFacade(ICarAccessories accessories, ICarBody body, ICarEngine engine, ICarModel model)
        {
            this.accessories = accessories;
            this.body = body;
            this.engine = engine;
            this.model = model;
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("Creating a Car\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\nCar creation is completed.");
        }
    }
}
