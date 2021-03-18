using StrategyPattern.Business.Models;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                OriginCountry = "Sweden",
                DestinationCountry = "Sweden"
            };
        }
    }
}
