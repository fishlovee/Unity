using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //y–年，m–月，d–日
            int y = 2008;
            int m = 8;
            int d = 8;
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400 + 1) % 7;
            //Console.WriteLine("2008 年 8 月 8 日是星期{0} ", week);

            Console.WriteLine(Convert.ToString(123, 2));


            Console.ReadKey();
        }
    }
}
