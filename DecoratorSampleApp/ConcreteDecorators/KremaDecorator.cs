using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class KremaDecorator : Decorator
    {
        private int discountRate = 5;

        public KremaDecorator(StarbucksUrun baseComponent)
            : base(baseComponent)
        {
            this.Name = "Kremalý kahve";
            this.Price = baseComponent.Price + 4.0;
        }
        
    }
}
