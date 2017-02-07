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
            */
            #endregion

            #region//第三题（？）
            /*
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                Console.WriteLine("现在是第{0}个数，累加值是{1}",i,sum);
                if (sum> 20)
                {
                    Console.WriteLine("累加值大于20，输出");
                    break;
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
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
                    a = 1;
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
            /*
            int min = 101;
            int max = 200;
            int mod = 0;
            int d = 0;//质数
            for (int i = min; i <= max; i++)
            {
                int e = 0;
                for (int j = 2; j < i; j++)
                {
                    mod = i % j;
                    if (mod != 0)
                    {
                        e++;
                        if (e == i - 2)
                        {
                            Console.WriteLine(i + "是质数");
                            d++;
                        }
                    }
                }
                int e = 0;
            }
            Console.WriteLine("一共有{0}个质数", d);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
            #region//↑标准解
            /*
            Console.WriteLine("please input min");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input max");
            int maxx = Convert.ToInt32(Console.ReadLine());
            int j;
            int tt = 0;
            bool boo = true;
            for (int i = min; i < maxx; i++)
            {
                boo = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        boo = false;
                        break;
                    }
                }
                if (boo)
                {
                    tt++;
                    Console.WriteLine(i + "," + tt);
                }
            }
            */
            #endregion
            #region//用while语句做
            /*
            int i = min;
            bool boo = true;
            do
            {
                boo = true;
                j = 2;
                do
                {
                    if (i % j == 0)
                    {
                        //不是素数
                        boo = false;
                        break;
                    }
                    j++;
                }
                while (i > j);
                if (boo)
                {
                    tt++;
                    Console.WriteLine(i+","+tt);
                }
                i++;
            }
            while (i >= min && i <= maxx) ;
            */
            #endregion

            #region//第十二题
            /*
            int t = 7;
            int k = 1;
            int sum = 0;
            while ((t * k) < 100)
            {
                sum += (k * t);
                k++;
                
            }
            Console.WriteLine("100以内{0}的倍数之和为{1}", t, sum);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
            #region//重做
            /*
            int min = 1;
            int maxx = 100;
            int sum = 0;
            for (int i = min; i <= maxx; i++)
            {
                if ((i % 7) == 0)
                {
                    sum += i;
                    Console.WriteLine("{0}是7的倍数，现在结果是{1}",i,sum);
                }
            }
            */
            #endregion

            #region//第十三题
            /*
            int min = 1;
            int max = 1000;
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                else
                {
                    ; ;
                }
            }
            Console.WriteLine("{0}-{1}之间所有的奇数之和为{2}", min, max, sum);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
            #region//重做
            /*
            int min = 1;
            int maxx = 1000;
            int sum = 0;
            for (int i = min; i <= maxx; i++)
            {
                if ((i % 2) != 0)
                {
                    sum += i;
                    Console.WriteLine("{0}是奇数，现在结果是{1}", i, sum);
                }
            }
            */
            #endregion

            #region//第十四题
            /*
            Random r = new Random();
            int a = r.Next(1, (100+1));
            int guess;
            int i = 0;
            Console.WriteLine("我们随机生成了一个数，你猜猜是多少？");
            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                i++;
                if (guess>a)
                {
                    Console.WriteLine("猜大了！");
                }
                if (guess<a)
                {
                    Console.WriteLine("猜小了！");
                }
            } while (guess != a);
            Console.WriteLine("你猜对了！一共猜了{0}次",i);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
            #region//重做
            /*
            Random random_i = new Random();
            int randomNum = random_i.Next(1, (100+1));
            int inputNum;
            bool boo = true;
            do
            {
                Console.WriteLine("Please input a number!");
                inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum == randomNum)
                {
                    boo = false;
                }
                else if (inputNum >= randomNum)
                {
                    Console.WriteLine("Smaller than this");
                }
                else if (inputNum <= randomNum)
                {
                    Console.WriteLine("Bigger than this");
                }
            }
            while (boo == true);
            Console.WriteLine("YES!");
            */
            #endregion

            #region//第十五题
            /*
            string account;
            string password;
            int t = 0;
            for (int i = 1; i <= 3; i++)
            {
                t++;
                Console.WriteLine("第{0}次尝试！", t);
                Console.WriteLine("Please Input Username!");
                account = Console.ReadLine();
                Console.WriteLine("Please Input Password");
                password = Console.ReadLine();
                if (account == "FFCL" && password == "888888")
                {
                    Console.WriteLine("登陆成功！");
                    break;
                }
                else
                {
                    Console.WriteLine("错误！");
                }
            }
            if (t >= 3)
            {
                Console.WriteLine("你TM是谁？来自哪里？为什么登陆？");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            */
            #endregion
            #region//重做

            string userName = "admin";
            string passWord = "888888";
            int repeat = 0;
            do
            {
                repeat++;
                Console.WriteLine("The {0} chance!",repeat);
                Console.WriteLine("Username?");
                string input_username = Console.ReadLine();
                Console.WriteLine("Password?");
                string input_password = Console.ReadLine();
                if (userName == input_username && passWord == input_password)
                {
                    Console.WriteLine("success!");
                    break;
                }
                else if (userName == input_username)
                {
                    Console.WriteLine("password error!");
                }
                else if (passWord == input_password)
                {
                    Console.WriteLine("usermane error!");
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
                if (repeat == 3)
                {
                    Console.WriteLine("DIE!");
                }
            } while (repeat<=3);

            #endregion
        }
    }
}
