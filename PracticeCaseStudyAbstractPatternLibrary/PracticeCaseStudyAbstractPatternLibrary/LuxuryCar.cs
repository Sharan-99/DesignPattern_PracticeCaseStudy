using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyAbstractPatternLibrary
{
    internal class LuxuryCar : Car
    {
        public LuxuryCar(CarType carType, Location location) : base(CarType.LUXURY, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to luxury car");
            Console.WriteLine(base.ToString());

        }

    }
}
