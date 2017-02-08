using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Program
    {

        static void Main(string[] args)
        {
            #region//第一题
            /*
            Console.WriteLine("请输入年份！");
            int year = Convert.ToInt32(Console.ReadLine());
            IsThisRunnian(year);
        }
        public static void IsThisRunnian(int y)
        {
            if (y % 400 == 0 || y % 4 == 0 && y % 100 != 0)
            {
                Console.WriteLine("是闰年！");
            }
            else
            {
                Console.WriteLine("不是闰年！");
            }
        }
        */
            #endregion

            #region//第二题
            /*
            Console.WriteLine("Please Input a character!");
            int char_int = Convert.ToChar(Console.ReadLine());
            char int_char = Convert.ToChar(ChangeCharacter(char_int));
            Console.WriteLine("Now the character is "+int_char);
        }
        private static int ChangeCharacter(int char_input)
        {
            if (char_input >= 65 && char_input <= 90)
            {
                char_input += 32;
            }
            else if (char_input >=97 && char_input<=122)
            {
                char_input -= 32;
            }
            else
            {
                ; ;
            }
            return char_input;
            */
            #endregion

            #region//第三题
            /*
            Console.WriteLine("Please input the frist number!");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the second number!");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the third number!");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The biggest is "+ABC(a,b,c));
        }
        public static double ABC (double a,double b,double c)
        {
            a = a > b ? a : b;
            a = a > c ? a : c;
            return a;
            */
            #endregion

            #region//第四题
            /*
            Console.WriteLine("Please input a number");
            double a = Convert.ToDouble(Console.ReadLine());
            WhatIsThis(a);
        }
        public static void WhatIsThis(double a)
        {
            if (a > 0)
            {
                Console.WriteLine("是正数！");
            }
            else
            {
                Console.WriteLine("不是正数！");
            }
            */
            #endregion

            #region//第五题
            /*
            Console.WriteLine("Please input your age!");
            int age = Convert.ToInt32(Console.ReadLine());
            AreYouAdult(age);
        }
        public static void AreYouAdult(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Come!");
            }
            else
            {
                Console.WriteLine("Get Out!");
            }
            */
            #endregion

            #region//第六题
            /*
            Console.WriteLine("Please input your score!");
            int score = Convert.ToInt32(Console.ReadLine());
            YourLevel(score);
        }
        public static void YourLevel(int score)
        {
            if (score>=90)
            {
                Console.WriteLine("A");
            }
            else if (score<90&&score>=80)
            {
                Console.WriteLine("B");
            }
            else if (score<80&&score>=70)
            {
                Console.WriteLine("C");
            }
            else if (score<70&&score>=60)
            {
                Console.WriteLine("D");
            }
            else if (score<60&&score>=0)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            */
            #endregion

            #region//第七题
            /*
            Console.WriteLine("Please input Minimum!");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input Maximum!");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + SumThemAll(min, max));
        }
        public static int SumThemAll(int min,int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }
            return sum;
            */
            #endregion

            #region//第八题
            /*
            Console.WriteLine("Please input Minimum!");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input Maximum!");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + SumThemAll(min, max));
        }
        public static int SumThemAll (int min,int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i%6==0)
                {
                    sum += i;
                }
                else
                {
                    ; ;
                }
            }
            return sum;
            */
            #endregion

            #region//第九题
            /*
            Console.WriteLine("Please input Minimum!");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input Maximum!");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There is {0} prime number between {1} and {2}", ShowPrimeNumber(min, max), min, max);
        }
        public static int ShowPrimeNumber(int min,int max)
        {
            int count = 0;
            for (int i = min; i <= max; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i==j)
                    {
                        count++;
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                }
            }
            return count;
            */
            #endregion

            #region//第十题
            /*
            Console.WriteLine("Please input Minimum!");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input Maximum!");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + SumThemAll(min, max));
        }
        public static int SumThemAll(int min,int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i%2!=0)
                {
                    sum += i;
                }
            }
            return sum;
            */
            #endregion

            #region//第十一题(a ^ 3 + b ^ 3 + c ^ 3 = abc 水仙花数）
            /*
            List<int> arr = new List<int>();
            int min = 100;
            int max = 999;
            int b = 0;
            for (int i = min; i <= max; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 100 % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    List<int> arr = ToArray(i,b);
                    b++;
                }
            }
            for (int i = 0; i < arr.Count;i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
        public static int[] ToArray(int i,int b)
        {
            List<int> arr = new List<int>();
            arr.Add(i);
            return List < int > arr;
            */
            #endregion

            #region//第十二题
            /*
            Console.WriteLine("Please input year!");
            int year = Convert.ToInt32(Console.ReadLine());
            CheckYourAnimals(year);
        }
        public static void CheckYourAnimals(int year)
        {
            year %= 12;
            switch (year)
            {
                case 0:
                    Console.WriteLine("猴");
                    break;
                case 1:
                    Console.WriteLine("鸡");
                    break;
                case 2:
                    Console.WriteLine("狗");
                    break;
                case 3:
                    Console.WriteLine("猪");
                    break;
                case 4:
                    Console.WriteLine("鼠");
                    break;
                case 5:
                    Console.WriteLine("牛");
                    break;
                case 6:
                    Console.WriteLine("虎");
                    break;
                case 7:
                    Console.WriteLine("兔");
                    break;
                case 8:
                    Console.WriteLine("龙");
                    break;
                case 9:
                    Console.WriteLine("蛇");
                    break;
                case 10:
                    Console.WriteLine("马");
                    break;
                case 11:
                    Console.WriteLine("羊");
                    break;
            }
            */
            #endregion

            #region//第十三题
            /*
            Console.WriteLine("Please input the length");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please input the {0} number",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            WhichIsBig(arr);
        }
        public static void WhichIsBig (int[] arr)
        {
            for (int i = 1; i < (arr.Length); i++)
			{
			    arr[i-1] = arr[i] > arr[i-1] ? arr[i] : arr[i-1];
			}
            Console.WriteLine("The Biggest is "+arr[arr.Length-1]);
            */
            #endregion

            #region//第十四题

            int[] arr = {12,425,254,32,1,865 };
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add();
            }

            #endregion

            #region//第十五题



            #endregion

            #region//第十六题



            #endregion
        }
    }
}
