using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine("---------------------");
            Ex27();
            Console.WriteLine("---------------------");
            Console.WriteLine("End");
            Console.ReadLine();
        }
        public static void Ex1() //75
        {
            Console.WriteLine("Please type hours:");
            int hours = int.Parse(Console.ReadLine());
            int count = 0;
            while(hours < 70)
            {
                if(hours >= 15)
                {
                    count++;
                }
                hours = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Over 15: " + count);
        }

        public static void Ex2() //100
        {
            Console.WriteLine("Enter family souls: ");
            int soul = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            double avg = 0;
            int over6 = 0;
            while (soul != 0)
            {
                count++;
                if(soul >= 6)
                {
                    over6++;
                }
                sum += soul;
                Console.WriteLine("Enter: ");
                soul = int.Parse(Console.ReadLine());
            }
            avg = sum / count;
            Console.WriteLine("Over 6: " + over6);
            Console.WriteLine("Average: " + avg);
        }

        public static void Ex3() //90
        {
            Console.Write("Price:");
            double price = double.Parse(Console.ReadLine());
            double max = 0.0;double min = double.MaxValue;
            while(price >= 0.0)
            {
                if(price > max)
                {
                    max = price;
                }
                if(price < min)
                {
                    min = price;
                }
                Console.Write("Price:");
                price = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Max price: " + max + "\nmin price: "+ min);
        }

        public static void Ex4()
        {
            double first = double.Parse(Console.ReadLine());
            double max1 = 0.0;double max2 = 0.0;
            while(first >= 0.0)
            {
                if(first > max1)
                {
                    max1 = first;
                }
                else if(first > max2)
                {
                    max2 = first;
                }
                first = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("First: "+ max1 + "Second: " + max2);
        } //90

        public static void Ex5()
        {
            Console.WriteLine("first");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("second");
            int secondNum = int.Parse(Console.ReadLine());
            int max = Math.Max(firstNum, secondNum);
            int min = Math.Min(firstNum, secondNum);
            int count = 1;
            int diff = max - min;
            while (count != 20 && diff != 1 && secondNum > 0 && firstNum > 0 )
            {
                max = Math.Max(firstNum, secondNum);
                min = Math.Min(firstNum, secondNum);
                diff = max - min;
                Console.WriteLine("Diff: " + diff);
                Console.WriteLine("first");
                firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("second");
                secondNum = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Number of inputs: " + count);

        }//90

        public static void Ex6()
        {
            double inp = double.Parse(Console.ReadLine());
            double old = 0; int count = 0;
            while(inp > 0)
            {
                old = inp;
                inp = double.Parse(Console.ReadLine());
                if(inp > old)
                {
                    count++;
                }
                else
                {
                    inp = -1;
                }
            }
            Console.WriteLine("Enough: " + count);
        }//100

        public static void Ex7() //100
        {
            Console.WriteLine("Please type serial number: ");
            int serial = int.Parse(Console.ReadLine());
            bool first;
            bool second;
            int firstT = 0;
            int secondT = 0;
            int bothFalse = 0;
            while(serial != 0)
            {
                Console.WriteLine("First task? ");
                first = bool.Parse(Console.ReadLine());
                Console.WriteLine("Second task? ");
                second = bool.Parse(Console.ReadLine());
                if (first == true)
                {
                    firstT++;
                }
                if(second == true)
                {
                    secondT++;
                }
                if(second == true && first == true)
                {
                    bothFalse++;
                }
                Console.WriteLine("Please type serial number: ");
                serial = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Students that did the first:\t" + firstT);
            Console.WriteLine("Students that did the second:\t" + secondT);
            Console.WriteLine("      Students that did both:\t" + bothFalse);
        }

        public static void Training() //100!!
        {
            Console.WriteLine("Enter:");
            int influence = int.Parse(Console.ReadLine());
            int sum = 0;
            double avg = 0;
            for(int i = 1; i <=30;i++)
            {
                sum = sum + influence;
                if(i % 3 == 0)
                {
                    avg = sum / 3;
                    Console.WriteLine("Avg is: "+ avg);
                    sum = 0;
                }

                Console.WriteLine("Enter:");
                influence = int.Parse(Console.ReadLine());
            }
        }

        public static void Ex24()
        {

            Console.WriteLine("Enter: ");
            int pupils = int.Parse(Console.ReadLine());
            int over = 0; int less = 0;
                while (pupils > 0)
                {
                    if (pupils > 41)
                    {
                        over++;
                    }
                    if (pupils < 15)
                    {
                        less++;
                    }
                    Console.WriteLine("Enter:");
                    pupils = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Over 41: " + over);
                Console.WriteLine("Less than 15: " + less);

        }
        public static void Ex3ab()
        {
            Console.WriteLine("Num: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;int max = 0;
            int slip = num;
            for(int i = 1; i <= num; i++)
            {
                if(num > max)
                {
                    max = num;
                }
            }
        }
        public static void ExZ()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= y;i++)
            {
                sum = sum * x;
            }
            Console.WriteLine("pow: " + sum);
        }
        public static void Ex27()
        {
            int j = 1; int i = 9;
            while(j != i)
            {
                j++; i--;
                Console.WriteLine(j + " " + i);
            }
        }
    }
}
