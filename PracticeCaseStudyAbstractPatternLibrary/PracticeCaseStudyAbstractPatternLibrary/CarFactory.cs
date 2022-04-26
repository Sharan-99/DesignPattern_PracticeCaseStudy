using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyAbstractPatternLibrary
{
    public abstract class CarFactory
    {
        public abstract Car BuildMicroCar(Location location);
        public abstract Car BuildMiniCar(Location location);
        public abstract Car BuildLuxuryCar(Location location);

    }
}
