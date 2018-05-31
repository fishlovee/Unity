using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_boxing
{
    /// <summary>
    /// 当一个方法的参数类型不能确定时，装箱操作就非常有用。
    /// 假设有 StoreHouse 仓库类，需要存储不同的物资，则可以使用装箱来实现
    /// 当 Add 的实参是 值类型 时，进行装箱，为引用类型时，由于所有引用类型都继承自 object ，因此可以满足所有要求。
    /// </summary>
    class StoreHouse
    {
        public object[] items;
        private int count;

        public StoreHouse(int c)
        {
            items = new object[c];
            count = 0;
        }

        public void Add(object obj)
        {
            if (count < items.Length)
            {
                items[count++] = obj;
                Console.WriteLine("添加:{0}", obj);

            }
            else
            {
                Console.WriteLine("仓库已满:{0}",obj);
            }
        }

    }



    class Program
    {
        /// <summary>
        /// 将值类型赋值给引用类型——装箱
        /// 装箱操作能把值类型数据打包到引用型变量中，使我们能够像使用对象一样使用值类型变量。
        /// </summary>
        static void BoxingExample()
        {
            int n = 123;
            Object obj = n; //装箱
            string s = obj.ToString();
        }

        /// <summary>
        /// 对于装入箱中的数据，可以通过拆箱（Unboxing）操作释放出来，拆箱操作要用显式转换。
        /// </summary>
        static void UnboxingExample()
        {
            int n = 123;
            Object obj = n;   //装箱
            int i = (int)obj; //拆箱
        }


        static void TestBoxing()
        {
            StoreHouse store = new StoreHouse(5);
            //向仓库里添加货物
            store.Add(100);
            store.Add(3.14);
            store.Add("Good");
            store.Add(new StoreHouse(2));
            store.Add(new Program());
            store.Add(new StoreHouse(5));
        }

        static void Main(string[] args)
        {
            TestBoxing();
        }
    }
}
