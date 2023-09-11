using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {

        public string StockSymbol { get; set; }
        public int    StockPrice  { get; set; }
    }
}
