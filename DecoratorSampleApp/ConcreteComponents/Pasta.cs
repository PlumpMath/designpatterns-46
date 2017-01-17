using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class Pasta : StarbucksUrun
    {
        public override string Name { get; set; } = "Pasta";

        public override double Price { get; set; } = 15.0;
    }
}
