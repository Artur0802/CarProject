using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Cars;
using CarProject.CarParts;
using CarProject.CarParts.CarBody;
using CarProject.CarParts.TuningParts.ForBody;
using CarProject.CarParts.TuningParts.ForEngine;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("KIA", "sedan", "gray", 15, "universal", "gas", 2000);
            car.Give_Info_For_Buing();
            Console.WriteLine();

            car.TuningCar(new CarPartWithTuning(new CarPartWithTuning(new CarPartWithTuning(car.CarBody), new Spoiler()), new Turbo()));
            car.Give_Info_For_Buing();

            Console.ReadKey();
        }
    }
}
