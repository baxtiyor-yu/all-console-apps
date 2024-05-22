using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.AppCalculator
{
    internal class CalcException : ApplicationException
    {
        public CalcException(string message) : base(message) { }
    }
}
