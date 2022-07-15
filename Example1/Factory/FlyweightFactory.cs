using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweighttPattern.Example1.Factory
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            Flyweight flyweight = null;

            if (_flyweights.TryGetValue(key, out flyweight)) { }
            else
            {
                _flyweights.Add(key, new ConcreteFlyweight(key));
            }

            return _flyweights[key];
        }
    }
}
