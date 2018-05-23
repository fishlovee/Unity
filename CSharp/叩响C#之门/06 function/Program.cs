using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_function
{
    class Program
    {
        static void Doubling(int[] array) { }
        static string CaculateWeekDay(int y, int m, int d)
        {
            if (m == 1 || m == 2) { m += 12; y--; }
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400 + 1) % 7;
            string weekstring = "";
            switch (week)
            {
                case 0: weekstring = "星期日"; break;
                case 1: weekstring = "星期一"; break;
                case 2: weekstring = "星期二"; break;
                case 3: weekstring = "星期三"; break;
                case 4: weekstring = "星期四"; break;
                case 5: weekstring = "星期五"; break;
                case 6: weekstring = "星期六"; break;
                default: break;
            }
            return weekstring; //返回结果
        }

        static void Swap(ref int x, ref int y) { int t = x; x = y; y = t; }
        static void Main(string[] args)
        {
            Console.WriteLine(CaculateWeekDay(2017, 12, 24));
            int[] numbers = { 1, 2, 3, 4, 5 };
            Doubling(numbers);

            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.ReadKey();
        }
    }
}
