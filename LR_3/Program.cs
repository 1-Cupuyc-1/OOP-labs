using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
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

            int t = Convert.ToInt16(Console.ReadLine()), N = Convert.ToInt16(Console.ReadLine()), fact = 1;
            double X = Convert.ToDouble(Console.ReadLine()), Y = Convert.ToDouble(Console.ReadLine()), A = 0;
            Console.WriteLine("Выражение для вычисления: A =  - sin(X) * lg(Y) / 1! + ln(X^3) * cos(Y^2) / 3! - sin(X^5) * lg(Y^3) / 5! + ln(X^7) * cos(Y^4) / 7! - ...\n");

            switch (t) {
                case 0:
                    { 
                        Console.WriteLine("\t\tВыражение вычисляется с помощью цикла for\nA = ");
                        double summand;
                        for (int i = 1, degree = i*2 - 1; i <= N; i++, degree = i*2-1, fact *= (degree - 1) * degree)
                        {
                            if (i % 2 == 1) {
                                summand = -Math.Sin(Math.Pow(X, degree)) * Math.Log10(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" - sin(X^{degree}) * lg(Y^{i}) / {degree}!");
                            }
                            else
                            {
                                summand = Math.Log(Math.Pow(X, degree)) * Math.Cos(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" + ln(X^{degree}) * cos(Y^{i}) / {degree}!");
                            }
                            A += summand;
                        }
                        Console.WriteLine($"= {A:0.000000}");
                        break;
                    }
                case 1:
                    { 
                        Console.WriteLine("\t\tВыражение вычисляется с помощью цикла while\nA = ");
                        int i = 1, degree;
                        double summand;
                        while (i <= N)
                        {
                            degree = i * 2 - 1;
                            if (i != 1) fact *= (degree - 1) * degree;
                            if (i % 2 == 1)
                            {
                                summand = -Math.Sin(Math.Pow(X, degree)) * Math.Log10(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" - sin(X^{degree}) * lg(Y^{i}) / {degree}!");
                            }
                            else
                            {
                                summand = Math.Log(Math.Pow(X, degree)) * Math.Cos(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" + ln(X^{degree}) * cos(Y^{i}) / {degree}!");
                            }
                            A += summand;
                            i++;
                        }
                        Console.WriteLine($"= {A:0.000000}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\t\tВыражение вычисляется с помощью цикла do...while\nA = ");
                        int i = 1, degree;
                        double summand;
                        do
                        {
                            //if (i > N) break;
                            degree = i * 2 - 1;
                            if (i != 1) fact *= (degree - 1) * degree;
                            if (i % 2 == 1)
                            {
                                summand = -Math.Sin(Math.Pow(X, degree)) * Math.Log10(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" - sin(X^{degree}) * lg(Y^{i}) / {degree}!");
                            }
                            else
                            {
                                summand = Math.Log(Math.Pow(X, degree)) * Math.Cos(Math.Pow(Y, i)) / fact;
                                Console.WriteLine($" + ln(X^{degree}) * cos(Y^{i}) / {degree}!");
                            }
                            A += summand;
                            i++;
                        } while (i <= N);
                        Console.WriteLine($"= {A:0.000000}");
                        break;
                    }
                default: Console.WriteLine($"Для t = {t} не определен цикл\nN = {N}, X = {X}, Y = {Y}"); break;
            }
            Console.SetOut(console_out); file_out.Close();
            Console.SetIn(console_in); file_in.Close();
        }
    }
}
