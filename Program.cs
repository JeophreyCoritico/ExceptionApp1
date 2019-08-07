using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            while (loop < 1)
            {
                try //try to do...5
                {
                    int n, sum = 0, m;





                    Console.WriteLine("Enter a number");
                    n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        throw (new ZeroOrLessException(""));
                    }
                    else if (n > 15)
                    {
                        throw (new GreaterThan15Exception(""));
                    }

                    while (n > 0)
                    {
                        m = n % 10;
                        sum = sum + m;
                        n = n / 10;
                    }

                    Console.WriteLine("Sum is = " + sum);

                }
                catch (FormatException e) //if try does not work
                {
                    Console.WriteLine("ERROR: " + e.Message);
                    loop = 1;
                }
                catch (ZeroOrLessException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                catch (GreaterThan15Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                finally //Whatever happends do this at the end
                {
                    Console.WriteLine(string.Format("{0:HH:mm tt}", DateTime.Now));
                }
            }
            Console.ReadKey();
        }
    }
}
