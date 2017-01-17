using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class ÇilekDecorator : Decorator
    {
        public ÇilekDecorator(StarbucksUrun baseComponent)
            : base(baseComponent)
        {
            this.Name = "Çilekli pasta";
            this.Price = baseComponent.Price + 2.0;
        }
    }
}
