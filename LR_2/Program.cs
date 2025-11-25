using System;
using System.IO;

namespace LR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter console_out = Console.Out;
            TextReader console_in = Console.In;
            var file_out = new StreamWriter(@"output.txt");
            var file_in = new StreamReader(@"input.txt");
            Console.SetOut(file_out);
            Console.SetIn(file_in);

            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            double a4 = Convert.ToDouble(Console.ReadLine());
            double a5 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"s = a1 * (a2 - a5)^0.5 / a3 = {a1} * ({a2} - {a5})^0.5 / {a3} = ");
            if ((a2 - a5) < 0) { Console.WriteLine("ERROR"); }
            else { var s = a1 * Math.Sqrt(a2 - a5) / a3; Console.WriteLine($"{s:0.000}"); }

            Console.Write($"k = (a3 / a1)^0.5 * a2^2 = ({a3} / {a1})^0.5 * {a2}^2 = ");
            if (a1 <= 0) { Console.WriteLine("ERROR"); }
            else { var k = Math.Sqrt(a3 / a1) * Math.Pow(a2, 2); Console.WriteLine($"{k:0.000}"); }

            Console.SetOut(console_out); file_out.Close();
            Console.SetIn(console_in); file_in.Close();


        }
    }
}
