using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class �ilekDecorator : Decorator
    {
        public �ilekDecorator(StarbucksUrun baseComponent)
            : base(baseComponent)
        {
            this.Name = "�ilekli pasta";
            this.Price = baseComponent.Price + 2.0;
        }
    }
}
