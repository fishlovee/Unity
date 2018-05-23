using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFilter
{
    class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public override string ToString()
        {
            return Name;
        }

        public Product(string name, decimal price = 0)
        {
            Name = name; // 为 ArrayList 列表提供构造函数
            Price = new Random().Next(5,25);
        }
    }


    /// <summary>
    /// 排序，C#1代码：通过辅助类实现比较接口及ArrayList的sort函数来实现排序
    /// </summary>
    class SortHelper_I : IComparer
    {
        public int Compare(Object x, object y)
        {
            Product productX = (Product)x;
            Product productY = (Product)y;
            return productX.ToString().CompareTo(productY.ToString());
        }
    }

    /// <summary>
    /// 排序，C#2代码：通过辅助类实现比较接口及ArrayList的sort函数来实现排序
    /// </summary>
    class SortHelper_II : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class SortedTest
    {
        /// <summary>
        /// 使用 非泛型ArrayList 及 SortHelper_I 进行排序
        /// </summary>
        public static void TestSorted_I()
        {
            ArrayList arrayList = new ArrayList
            {
                {"Wangwu" },
                { "zhaoliu"},
                {"liqi" }
            };

            arrayList.Sort(new SortHelper_I());
        }

        /// <summary>
        /// 使用泛型list和SortHelper_II
        /// </summary>
        public static void TestSorted_II()
        {
            List<Product> list = new List<Product>
            {
                new Product("wangyu"),
                new Product("zhaoliu"),
                new Product("liqi"),
            };

            list.Sort(new SortHelper_II());
        }

        /// <summary>
        /// 使用 lambda 表达式及泛型list进行排序
        /// </summary>
        public static void TestSorted_III()
        {
            List<Product> list = new List<Product>
            {
                new Product("wangyu"),
                new Product("zhaoliu"),
                new Product("liqi"),
            };

            list.Sort((x, y) => { return x.ToString().CompareTo(y.ToString()); });
        }
    }

    /// <summary>
    /// 查询集合：打印list中的所有单价大于10的元素
    /// </summary>
    class CollectionQuery
    {
        public static List<Product> GetSimpale()
        {
            return new List<Product>
            {
                new Product("wangyu"),
                new Product("zhaoliu"),
                new Product("liqi")
            };
        } 

        /// <summary>
        /// 使用foreach条件遍历
        /// </summary>
        public static void ForEach()
        {
            List<Product> list = GetSimpale();
            foreach (var item in list)
            {
                if (item.Price > 10)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        /// <summary>
        /// 使用委托分别进行条件判断和打印
        /// </summary>
        public static void Action_I()
        {
            Predicate<Product> predicate = (x) => { return x.Price > 10; };
            Action<Product> action = Console.WriteLine;
            List<Product> list = GetSimpale();
            List<Product> rst = list.FindAll(predicate);
            rst.ForEach(action);
        }

        /// <summary>
        /// 使用委托合并条件判断和打印
        /// </summary>
        public static void Action_II()
        {
            List<Product> list = GetSimpale();
            list.FindAll((x) => { return x.Price > 10; }).ForEach(Console.WriteLine);
        }

        /// <summary>
        /// 使用 LINQ 条件语句
        /// </summary>
        public static void LinQ()
        {
            List<Product> list = GetSimpale();
            foreach (var item in list.Where(p => p.Price > 10))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
