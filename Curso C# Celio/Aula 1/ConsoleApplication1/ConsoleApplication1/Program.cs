using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do{
                System.Console.WriteLine("aaa");
                a++;
                

            }while(a <= 10);

            string b = System.Console.ReadLine();
            
            switch (b)
            {
                case "a":
                    System.Console.WriteLine("foi digitado a");
                    break;

                case "b":
                    System.Console.WriteLine("foi digitado b");
                    break;

                default:
                    System.Console.WriteLine("Nada foi digitado ");
                    break;

            }

            System.Console.ReadLine();
        }
    }
}
