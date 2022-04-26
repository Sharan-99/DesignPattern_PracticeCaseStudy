using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyAbstractPatternLibrary
{
    internal class MiniCar : Car
    {
        public MiniCar(CarType carType, Location location) : base(CarType.MINI,location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Mini car");
            Console.WriteLine(base.ToString());
        }
    }
}
