using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class Kahve : StarbucksUrun
    {
        public override string Name { get; set; } = "Kahve";

        public override double Price { get; set; } = 10.0;
    }
}
