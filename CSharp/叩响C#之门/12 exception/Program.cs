using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_exception
{
    class NegativeException:ApplicationException
    {
        public NegativeException() : base("对负数进行非法操作") { }
        public NegativeException(string message) : base(message) { }
    }

    class Program
    {
        static void DiviseZero()
        {
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("100 / {0} = {1}", d, 100 / d);
            Console.ReadKey();
        }

        static void  TryException()
        {
            try
            {
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("100 / {0} = {1}", d, 100 / d);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("除数为0异常！");
            }
            catch (FormatException)
            {
                Console.WriteLine("输入串无法转换为数字！");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void ExceptionProperty()
        {
            int d = 0;
            try
            {
                d = Convert.ToInt32(Console.ReadLine());
                if (d >= 10 || d <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("message:{0}",a.Message);
                Console.WriteLine("stacktrace:{0}", a.StackTrace);
            }
            finally
            {
                Console.WriteLine("100 / {0} = {1}", d, 100 / d);
            }
            Console.ReadKey();
        }

        static void SelfDefine()
        {
            int d = 0;
            try
            {
                d = Convert.ToInt32(Console.ReadLine());
                if (d < 0)
                {
                    throw new NegativeException("非法负数：" + d);
                }
            }
            catch (NegativeException n)
            {
                Console.WriteLine("message:{0}", n.Message);
                Console.WriteLine("stack:{0}", n.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            SelfDefine();
        }
    }
}
