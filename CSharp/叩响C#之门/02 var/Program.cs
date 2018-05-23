using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_var
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 下面定义变量
            //int a = 7;
            //int b = 2;
            //int sum, dif, pro, quo;

            //// 下面进行计算
            //sum = a + b; //加
            //dif = a - b; //减
            //pro = a * b; //乘
            //quo = a / b; //除

            //// 下面输出结果
            //Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            //Console.WriteLine("{0} – {1} = {2}", a, b, dif);
            //Console.WriteLine("{0} * {1} = {2}", a, b, pro);
            //Console.WriteLine("{0} / {1} = {2}", a, b, quo);


            //float x = 3.14159f;
            //double y = 4.152f;

            //float fxiaom = 44444.14f;
            //float fxiaoh = 66666.51f;
            //Console.WriteLine(fxiaoh + fxiaom);


            for (int i = 0; i < 5; i++)
            {
                int nxincount = i == 0 || i == 4 ? 1 : 2;
                int nSpaceCount = i <=2 ? 10 - i:10 - 2 + i - 2;
                for (int ispace = 0; ispace < nSpaceCount; ispace++)
                {
                    Console.Write(" ");
                }
                for (int ix = 0; ix < nxincount; ix++)
                {
                    Console.Write("*");
                    for (int ispace = 0; ispace < (10 - nSpaceCount)*2 - 1; ispace++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
