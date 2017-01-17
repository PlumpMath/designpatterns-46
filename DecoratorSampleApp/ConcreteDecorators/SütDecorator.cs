using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class S�tDecorator : Decorator
    {
        public S�tDecorator(StarbucksUrun baseComponent)
            : base(baseComponent)
        {
            this.Name = "S�tl� Kahve";
            this.Price =  baseComponent.Price + 1.0;
        }
    }
}
