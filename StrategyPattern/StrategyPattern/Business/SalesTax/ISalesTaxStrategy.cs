using StrategyPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Business.SalesTax
{
    interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
