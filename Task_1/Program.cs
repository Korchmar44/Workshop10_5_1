using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Calc_Service;
using Task_1.Interfaces;
using Task_1.Log;

namespace Task_1
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();

            var calculator = new Calculator(Logger);

            calculator.Run();
        }
    }
}
