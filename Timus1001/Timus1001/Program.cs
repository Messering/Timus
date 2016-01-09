//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Timus1001
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true) {
//                try
//                {
//                    Console.WriteLine("Enter number or if exit enter Z: ");
//                    string S = Console.ReadLine();
//                    if (S == "Z" || S== "z") break;
//                    else {
//                        double a = Double.Parse(S);
//                        if (a >= 0 || a <= Math.Pow(a, 18))
//                        {
//                            Console.WriteLine("Sqrt(a)={0:}", Math.Round(Math.Sqrt(a), 4));
//                        }
//                        else {
//                            Console.WriteLine("Number exit period");
//                        }
//                    }

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Is not number: {0}",e);
//                    throw;
//                }

//            }

//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1001
{
    class Program
    {
        static void Main(string[] args)
        {
                    double[] a = Console.ReadLine().Split(new char[] { ' ','\n' }, StringSplitOptions.RemoveEmptyEntries).Select(i => double.Parse(i)).ToArray<double>();
                    for (int i = 0; i <a.Length; i++)                   
                    Console.WriteLine("{0:}", Math.Round(Math.Sqrt(a[i]), 4));
            Console.ReadKey();                     
        }
    }
}
