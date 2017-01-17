using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    public abstract class Decorator : StarbucksUrun
    {
        StarbucksUrun baseComponent = null;

        protected Decorator(StarbucksUrun baseComponent)
        {
            this.baseComponent = baseComponent;
        }

        public override string Name { get; set; } = "Undefined Decorator";

        public override double Price { get; set; } = 0.0;

    }
}