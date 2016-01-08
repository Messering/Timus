using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus_1785
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number monster: ");
            int numberMonster = int.Parse(Console.ReadLine());
            if (numberMonster >= 1 && numberMonster <= 2000) {
                if(numberMonster>=1 && numberMonster <= 4)
                {
                    Console.WriteLine("few");
                }
                if(numberMonster >= 5 && numberMonster <= 9)
                {
                    Console.WriteLine("several");
                }
                if (numberMonster >= 10 && numberMonster <= 19)
                {
                    Console.WriteLine("pack");
                }
                if (numberMonster >= 20 && numberMonster <= 49)
                {
                    Console.WriteLine("lots");
                }
                if (numberMonster >= 50 && numberMonster <= 99)
                {
                    Console.WriteLine("horde");
                }
                if (numberMonster >= 100 && numberMonster <= 249)
                {
                    Console.WriteLine("throng");
                }
                if (numberMonster >= 250 && numberMonster <= 499)
                {
                    Console.WriteLine("swarm");
                }
                if (numberMonster >= 500 && numberMonster <= 999)
                {
                    Console.WriteLine("zounds");
                }
                if(numberMonster>=1000)
                {
                    Console.WriteLine("legion");
                }
            }
            else
            {
                Console.WriteLine("Number monster exit period");
            }
        }
    }
}
