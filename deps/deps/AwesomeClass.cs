using System;
using AutoMapper;

namespace Deps
{
    public class Order { }

    public class OrderDto { }
    public class AwesomeClass
    {
        public static string PrintAwesome() => "Hi from awesome class";

        public void TestDependency()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());

        }
    }
}
