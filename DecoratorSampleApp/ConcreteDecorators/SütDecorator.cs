using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class SütDecorator : Decorator
    {
        public SütDecorator(StarbucksUrun baseComponent)
            : base(baseComponent)
        {
            this.Name = "Sütlü Kahve";
            this.Price =  baseComponent.Price + 1.0;
        }
    }
}
