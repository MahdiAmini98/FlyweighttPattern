using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweighttPattern.Example1;

namespace FlyweighttPattern.Example1
{
    public class ConcreteFlyweight : Flyweight
    {
        private string _intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public override void Operation(string extrisicstate)
        {
            Console.WriteLine("ConcreteFlyweight.Operation('" + _intrinsicState + "'):\"" + extrisicstate + "\"");
        }
    }
}
