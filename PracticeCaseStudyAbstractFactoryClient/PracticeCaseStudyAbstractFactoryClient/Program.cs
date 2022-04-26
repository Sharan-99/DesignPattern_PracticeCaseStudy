using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using PracticeCaseStudyAbstractPatternLibrary;

namespace PracticeCaseStudyAbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            carFactory.BuildMicroCar(Location.USA);
            carFactory.BuildMiniCar(Location.INDIA);
            carFactory.BuildLuxuryCar(Location.DEFAULT);
            Console.ReadKey();

        }
    }
}
