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
            #region//第一题
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

            #region//第二题
            /*
            string pas;
            string user;
            do
            {
                Console.WriteLine("Please Input Username!");
                user = Console.ReadLine();
                Console.WriteLine("Please Input Password");
                pas = Console.ReadLine();
            }
            while (user != "admin" && pas != "888888");
            Console.WriteLine("Welcome!");
            Console.ReadKey();

            #endregion
            */
            #endregion

            #region//第三题（？）
            /*

            */
            #endregion

            #region//第四题
            /*
            int f = 0;
            for (int i = 1; i <= 100; i++)
            {
                f+=i;
            }
            int ff = 0;
            int t = 7;
            int k = 1;
            int sum = 0;
            while ((t * k)<100)
            {
                sum += (t * k);
                k++;
            }
            ff = f - sum;
            Console.WriteLine(ff);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第五题
            /*
            int a = 0;
            for (int i = 1; i <= 10; i++)
            {
                a += i;
            }
            Console.WriteLine("1+2+3+4+5+6+7+8+9+10="+a);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第六题
            /*
            int t = 6;
            int k = 0;
            do
            {
                k++;
            }
            while ((t * k) < 100);
            Console.WriteLine("100以内6的倍数有{0}个",k-1);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第七题
            /*
            Console.WriteLine("你们班有多少人？");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩",i);
                int b = Convert.ToInt32(Console.ReadLine());
                sum += b;
            }
            int average = sum / a;
            Console.WriteLine("你们班的总成绩为{0}，平均成绩为{1}",sum,average);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第八题
            /*
            double a = 80000;
            double b = 1.25;
            int c = 2006;
            do
            {
                c++;
                a *= b;
            } while (a<200000);
            Console.WriteLine("到{0}年的时候培训学员人数将达到20万人",c);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第九题
            /*
            double a = 0;
            double b = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入第{0}个数",i+1);
                a = Convert.ToDouble(Console.ReadLine());
                b = a > b ? a : b;
            }
            Console.WriteLine("十个数中最大的数为"+b);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第十题
            /*
            int a = 1;
            int b = 0;
            int c = 0;
            int d = 0;
            int num = 0;

            do
            {
                if (a+b+c+d == 5)
                {
                    Console.WriteLine("{0}{1}{2}{3}",a,b,c,d);
                    a++;
                    num++;
                }
                else
                {
                    a++;
                }
                if (a>9)
                {
                    b++;
                    a = 0;
                    if (b>9)
                    {
                        c++;
                        b = 0;
                        if (c>9)
                        {
                            d++;
                            c = 0;
                        }
                    }
                }
            } while (a+b+c+d<36);
            Console.WriteLine("满足条件的整数有{0}个",num);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion

            #region//第十一题

            int min = 101;
            int max = 200;
            int mod = 0;
            int d = 0;//质数
            int e = 0;//被膜掉的个数
            for (int i = min; i <= max; i++)
            {
                for (int j = 2; j <= 19; j++)
                {
                    mod = i % j;
                    if (mod != 0)
                    {
                        e++;
                        if (e==18)
                        {
                            Console.WriteLine(i+"是质数");
                            d++;
                        }
                    }
                    
                }
                e = 0;
            }
            Console.WriteLine("一共有{0}个质数", d);

            #endregion

            #region//第十二题

            //太简单，不做

            #endregion
        }


    }
}
