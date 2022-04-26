using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyAbstractPatternLibrary
{
    internal class MicroCar : Car
    {
        public MicroCar(CarType carType, Location location) : base(CarType.MICRO,location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro car");
            Console.WriteLine(base.ToString());
        }
    }
}
