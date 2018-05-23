using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_flow_control
{
    class Program
    {

        static double space()
        {
            double space = 0;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2;
            space = Math.Sqrt(p);
            
            Console.WriteLine("a = {0},b = {1},c = {2},space = {3}", a, b, c, space);

            return space;
        }

        static void fractal()
        {
            //fractal
            double x0, y0;  //原始点坐标
            double x1, y1;  //z n-1 的实部和虚部
            double x2, y2;  //z n 的实部和虚部
            double NN; //模的平方
            int n; //记录迭代次数
                   //用双层 for 语句遍历所有点
            for (y0 = 1.2; y0 >= -1.2; y0 -= 0.05)
            {
                for (x0 = -0.6; x0 <= 1.77; x0 += 0.03)
                {
                    //对于点(x,y)，用下面的代码计算迭代次数
                    n = 0;
                    x1 = x0;
                    y1 = y0;
                    NN = x1 * x1 + y1 * y1;
                    //当模的平方小于 4 且迭代次数小于 40 时进行迭代
                    while ((NN < 4) && (n < 40))
                    {
                        //由 z1 的实部和虚部计算 z2 的实部和虚部
                        x2 = (x1 * x1) - (y1 * y1) - x0;
                        y2 = (2 * x1 * y1) - y0;
                        //计算 z2 的模的平方
                        NN = (x2 * x2) + (y2 * y2);
                        //记录迭代次数
                        n++;
                        //为下次迭代做准备
                        x1 = x2;
                        y1 = y2;
                    }
                    //由于所学知识有限，我们暂时用输出字符代替输出颜色
                    switch (n % 4)
                    {
                        case 0: Console.Write("."); break;
                        case 1: Console.Write("o"); break;
                        case 2: Console.Write("O"); break;
                        case 3: Console.Write("@"); break;
                    }
                }
                Console.Write("\n"); //输出的字符换行
            }
        }

        static void Main(string[] args)
        {
            // space();
            fractal();

            Console.ReadKey();
            
        }

       
    }
}
