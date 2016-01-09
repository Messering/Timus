using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1787
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int[] date2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int sum=0,sult=0;
            for (int i = 0; i < date1[1]; i++)
            {
                sum = date2[i] - date1[0]+sult;
                if (sum <= 0) sult=0;
                else
                {
                    sult = sum;
                }
            }
            Console.WriteLine(sult);
            Console.ReadKey();     
        }
    }
}
