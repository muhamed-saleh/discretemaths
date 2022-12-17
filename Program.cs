using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("inter the first number in the domain\n______");
            int FirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("inter the second number in the domain\n______");
            int SecondNum = int.Parse(Console.ReadLine());  
            int j = 0;
            int flag = 0;

            if (SecondNum >= 2 && FirstNum>=2) { Console.WriteLine("the prime numbers in the domain are:"); }
            else { Console.WriteLine("there are no prime numbers in the domain");return; }
            
               
            for (; FirstNum <= SecondNum; FirstNum++)
            {
                j = 2;
                flag = 0;
                while (j <= (FirstNum / 2))
                {
                    if (FirstNum % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    j++;
                }

                if (flag == 0)
                    Console.WriteLine(FirstNum );

            }
            
        }
    }
}
