using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num, i, flage, n1, n2;
            Console.WriteLine("ENTER N1 ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = int.Parse(Console.ReadLine());
            num = n1;
            while (num<=n2)
            {
                flage = 0;
                    for(i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {

                        flage = 1; 
                        break;
                    }
                }

                    if (flage==0)
                    Console.WriteLine("number:"+num);   
                    num++;
                        


            }

            Console.ReadKey();  








        }
    }
}
