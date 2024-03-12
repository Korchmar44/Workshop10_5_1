using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;
using Task_1.Log;

namespace Task_1.Calc_Service
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public double Add(double num1, double num2)
        {
            Logger.Event("Выполняется операция сложения");
            return num1 + num2;
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Введите аргумент 1");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите аргумент 2");
                double num2 = Convert.ToDouble(Console.ReadLine());

                var resalt = Add(num1, num2);

                Console.WriteLine($"Сумма чисел: {num1} и {num2} равна {resalt}");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
            Console.ReadKey();
        }
    }
}
