using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweighttPattern.Example1
{
    internal class UnSharedConcreteFlyweight : Flyweight
    {
        private readonly IEnumerable<Flyweight> _flyweightList;

        public UnSharedConcreteFlyweight(IEnumerable<Flyweight> flyweightList)
        {
            _flyweightList = flyweightList;
        }
        public override void Operation(string extrisicstate)
        {
            Console.WriteLine("UnSharedConcreteFlyweight--------");
            foreach (var item in _flyweightList)
            {
                item.Operation(extrisicstate);
            }
        }
    }
}
