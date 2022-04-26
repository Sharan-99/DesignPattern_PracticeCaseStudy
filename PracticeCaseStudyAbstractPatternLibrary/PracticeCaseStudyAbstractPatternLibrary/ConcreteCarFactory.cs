using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyAbstractPatternLibrary
{
    public class ConcreteCarFactory : CarFactory
    {
        public override Car BuildMicroCar(Location location)
        {
            return new MicroCar(CarType.MICRO,location);
        }
        public override Car BuildMiniCar(Location location)
        {
            return new MiniCar(CarType.MINI, location);
        }
        public override Car BuildLuxuryCar(Location location)
        {
            return new LuxuryCar(CarType.LUXURY, location);
        }
    }
}
