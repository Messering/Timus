using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus2001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int[] date2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int[] date3 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            Console.WriteLine((date1[0]-date3[0])+" "+ (date1[1]-date2[1]));
        }
    }
}
