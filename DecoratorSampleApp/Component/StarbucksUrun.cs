using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    public abstract class StarbucksUrun
    {
        public abstract string Name { get; set; } 

        public abstract double Price { get; set; }
    }
}
