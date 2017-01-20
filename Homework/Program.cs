using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region//第一题
            /*
            Console.WriteLine("Please Input Username!");
            string Username = Console.ReadLine();
            Console.WriteLine("Please Input Password");
            string Password = Console.ReadLine();
            if (Username == "admin")
            {
                if (Password == "888888")
                {
                    Console.WriteLine("Login Successful!\n");
                }
                else
                {
                    Console.WriteLine("Password Error!\n"); 
                }
            }
            else
            {
                if (Password == "888888")
                {
                    Console.WriteLine("Username Error!\n");
                }
                else
                {
                    Console.WriteLine("ALL ERROR!\n");
                    Console.WriteLine("Who The Hell Are You?!\n");
                }
            }
            Console.ReadKey();
            */
            #endregion

            #region//第二题
            /*
            Console.WriteLine("Please input your age!");
            string input_age = Console.ReadLine();
            int age = Convert.ToInt32(input_age);
            if (age < 10)
            {
                Console.WriteLine("You are too small!");
            }
            else if (age > 18)
            {
                Console.WriteLine("Now you can go");
            }
            else
            {
                Console.WriteLine("Go on?\nPress 'YES'（大写的） to continue");
                string input_YN = Console.ReadLine();
                if (input_YN == "YES")
                {
                    Console.WriteLine("Now you can go");
                }
                else
                {
                    Console.WriteLine("Cancel...");
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第三题
            /*
            Console.WriteLine("Please input a character");
            string ii = Convert.ToString(Console.ReadLine());
            char i = Convert.ToChar(ii);

            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("This is 数字");
            }
            else if (i >= 65 && i <= 90)
            {
                Console.WriteLine("This is 大写字母");
            }
            else if (i >= 97 && i <= 122)
            {
                Console.WriteLine("This is 小写字母");
            }
            else
            {
                Console.WriteLine("这是什么鬼？");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第四题
            /*
            Console.WriteLine("Please input your score!");
            string score_input = Console.ReadLine();
            double score = Convert.ToDouble(score_input);
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else if (score < 60 && score >= 0)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第五题
            /*
            Console.WriteLine("Please input a number!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                a += 100;
            }
            else if (a < 0)
            {
                a += 500;
            }
            else
            {
                ; ;
            }
            Console.WriteLine(a);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第六题
            /*
            Console.WriteLine("你有多少个蛋？");
            int egg = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            double bad_egg = r.Next(0, egg);
            double eat = 100 * (bad_egg / egg);
            if (eat < 10)
            {
                Console.WriteLine("蛋很好吃呢~");
            }
            if (eat >= 10)
            {
                Console.WriteLine("卧槽！{0}个坏蛋！什么鬼玩意！退货！",bad_egg);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第七题
            /*
            Console.WriteLine("Please input a number!");
            double i = Convert.ToDouble(Console.ReadLine());
            int ii = Convert.ToInt32(i);
            Console.WriteLine(ii);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第八题
            /*
            Console.WriteLine("Please input a year!");
            int y = Convert.ToInt32 (Console.ReadLine());
            if ((y%400) == 0)
            {
                Console.WriteLine("是闰年！");
            }
            else
            {
                if (((y%4) == 0) && ((y%100) != 0))
                {
                    Console.WriteLine("是闰年！");
                }
                else
                {
                    Console.WriteLine("不是闰年！");
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第九题
            /*
            Console.WriteLine("Please input the first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the third number");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = a > b ? a : b;
            double e = d > c ? d : c;
            Console.WriteLine("The biggest number is "+e);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第十题
            /*
            Random r2 = new Random();
            int egg = r2.Next(1,10);
            Random r = new Random();
            double bad_egg = r.Next(0, egg);
            Console.WriteLine("盖茨买了"+egg+"个鸡蛋");
            Console.WriteLine("其中有"+bad_egg+"个坏蛋");
            if (bad_egg < 5)
            {
                Console.WriteLine("蛋很好吃呢~");
            }
            if (bad_egg >= 5)
            {
                Console.WriteLine("什么鬼玩意！退货！");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第十一题
            /*
            Console.WriteLine("Please input a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input b");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a % b == 0 || a + b > 100)
            {
                Console.WriteLine("Return a="+a);
            }
            else
            {
                Console.WriteLine("Return b="+b);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
        }
    }
}
