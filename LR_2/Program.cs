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

            Console.Write("s = (a2 - a1 + a3)**0.5 / a3 + a4 / 100 = ");
            if ((a2 - a1 + a3) < 0 || a3 == 0) { Console.WriteLine("ERROR"); }
            else { var s = Math.Sqrt(a2 - a1 + a3) / a3 + a4 / 100; Console.WriteLine($"{s:0.000}"); }

            Console.Write("k = ((a3 + a4) / (a1 - a3))**0.5 * (a2 - a5)**2 = ");
            if ((a1 - a3) <= 0) { Console.WriteLine("ERROR"); }
            else { var k = Math.Sqrt((a3+a4) / (a1 - a3)) * Math.Pow((a2 - a5), 2); Console.WriteLine($"{k:0.000}"); }

            Console.SetOut(console_out); file_out.Close();
            Console.SetIn(console_in); file_in.Close();


        }
    }
}
