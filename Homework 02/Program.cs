using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个人的年龄");
                int age = Convert.ToInt32(Console.ReadLine());
                sum += age;
                if (age > 100 || age < 0)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                else
                {
                    ; ;
                }
            }
            sum /= 5;
            Console.WriteLine("平均年龄为" + sum);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region

            Console.WriteLine("Please Input Username!");
            string Username = Console.ReadLine();
            Console.WriteLine("Please Input Password");
            string Password = Console.ReadLine();

            do
            {
                
            } while (Username == "admin" && Password == "888888");
            Console.ReadKey();

            #endregion

        }


    }
}
