using System;

namespace GH_Repo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub Upload 2");

            Console.WriteLine("Calculator Inputs");
            Console.WriteLine("Operations- Input any one from [ADD, SUB, MUL, DIV]: ");
            var optr = Console.ReadLine();
            Console.WriteLine("Input first integer:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            var b = Convert.ToInt32(Console.ReadLine());

            Calculator calc = new Calculator();
            string result = calc.operations(optr, a, b).ToString();
            Console.WriteLine(String.Format("Results: {0}", result));
        }
    }
}
