using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_积分
{
    /// <summary>
    /// 功能：求定积分
    /// 日期：2018-01-03
    /// 求定积分，需要知道积分上限 a ，积分下限 b 和被积函数 f(x) 
    /// 需要把被积函数以参数的形式传递给定积分函数，所以需要利用委托实现。
    /// 
    /// </summary>
    class DefiniteIntegral
    {
        //被积函数 F1(x)=2x+1
        public static double F1(double d) { return 2 * d + 1; }
        public delegate double DelegateFunc(double x);

        // 积分函数
        public static double Definite(DelegateFunc delegateFunc, double dLow, double dUp)
        {
            double dRet = 0;
            const int nCount = 1000;
            double dDerta = (dUp - dLow) / nCount;
            for (int i = 0; i < nCount; i++)
            {
                dRet += (delegateFunc(dLow + i * dDerta)) * dDerta;
            }

            return dRet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double dRet = DefiniteIntegral.Definite(DefiniteIntegral.F1, 1, 8);
            double dRet2 = DefiniteIntegral.Definite(delegate(double x){ return x * x; }, 1, 8);

            DefiniteIntegral.DelegateFunc f3 = (double x) => { return x * x; };
            double dRet3 = DefiniteIntegral.Definite(f3, 1, 8);
            Console.WriteLine("函数[2x+1]积分范围[{0},{1}],面积{2}",1,8, dRet3);
            Console.ReadKey();
        }
    }
}
