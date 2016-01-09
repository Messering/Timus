using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1877
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstKey = Console.ReadLine();
            string secondKey = Console.ReadLine();            
            if (firstKey.Length == 4 && secondKey.Length == 4) {
                int count = 0;
                bool bat = true, answ=false;
                int fk1 = Int32.Parse(firstKey),
                    fk2 = Int32.Parse(secondKey);

                while (bat)
                {
                    if (count % 2 == 0)
                    {
                        if (count == fk1)
                        {
                            answ = true;
                            bat = false;
                        }
                    }
                    else if (count == fk2)
                    {
                        answ = true;
                        bat = false;
                    }

                    if (count>Math.Max(fk1, fk2))
                    {
                        bat = false;
                    }
                    count++;
                }

                    if (answ)
                    {
                        Console.WriteLine("yes");
                    }
                else
                {
                    Console.WriteLine("no");
                }
                
                Console.ReadKey();
            }
        }
    }
}
