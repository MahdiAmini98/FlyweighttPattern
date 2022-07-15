using FlyweighttPattern.Example1;
using FlyweighttPattern.Example1.Factory;
using System;
using System.Collections.Generic;

namespace FlyweighttPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
           var obj1 = factory.GetFlyweight("Test1");
           var obj2 = factory.GetFlyweight("Test2");
           var obj3 = factory.GetFlyweight("Test1");
            obj1.Operation("sample1 extrinsic state");
            obj2.Operation("sample2 extrinsic state");
            obj3.Operation("sample3 extrinsic state");

            UnSharedConcreteFlyweight flyweights = new UnSharedConcreteFlyweight(new Flyweight[]
            {
                factory.GetFlyweight("Test1"),
                factory.GetFlyweight("Test2"),
                factory.GetFlyweight("Test3"),
                factory.GetFlyweight("Test4"),
            });
            flyweights.Operation("extrinsic ---> UnSharedConcreteFlyweight");
            Console.ReadKey();
            // Console.WriteLine("Hello World!");
        }
    }
}
