using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfunctions.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] zimun = Maarach1(10);
            foreach (int i in zimun)
            { //כי פשוט למדתי ככה בפייתון
                Console.WriteLine(i);
            }
            

        }
        public static int[] Maarach1(int x)
        {
            int[] arr = new int[x];
            for(int i = 0; i < x; i++)
            {
                arr[x] = i;
            }
            return arr;
        }
    }
}
