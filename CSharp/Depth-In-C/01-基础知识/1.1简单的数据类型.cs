using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depth_In_C
{
    // C#1中的构造与容器
    class Product
    {
        /// <summary>
        /// C#1中，get和set不能单独的声明访问属性，如果get是public的，那么set也一定是public的
        /// </summary>
        string name;
        public string Name { get { return name; } } 

        decimal price;
        public decimal Price { get { return price; } set { price = value; } }

        Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// C#1中的容器是非泛型的，可以添加任何类型的变量
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetSampleProducts()
        {
            ArrayList arrayList = new ArrayList();    
            arrayList.Add(new Product("huliang", 14.56m));
            arrayList.Add(new Product("fafa", 89.56m));
            arrayList.Add(new Product("zhongliu", 65.2m));
            return arrayList;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", this.name, this.price);
        }
    }

    class Product_II
    {
        /// <summary>
        /// C#2 中可以单独的声明set和get的访问属性，但是它们的访问属性不能比属性本身的访问属性大
        /// </summary>
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class ProductNameCompare : IComparer<Product_III>
    {
        public int Compare(Product_III x, Product_III y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }


    /// <summary>
    /// 命名实参：使用readonly、const等比使用私有的set属性更好，使用前者时及时是class自身也不能改变该成员变量
    /// </summary>
    class Product_IIII
    {
        readonly string name;
        public string Name { get { return name; } }
        readonly decimal price;
        public decimal Price { get { return price; } }

        // 构造函数
        public Product_IIII(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product_IIII> GetProducts()
        {
            return new List<Product_IIII>
            {
                new Product_IIII(price:1.5m,name:"wangwang"),
                new Product_IIII(name:"tiantian",price:8.5m),
                new Product_IIII(name:"xiangjun",price:16.5m)
            };
        }
    }

    class IProductCompare : IComparer<Product_III>
    {
        public int Compare(Product_III x, Product_III y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    /// <summary>
    /// 自动访问属性及更简单的初始化
    /// </summary>
    class Product_III
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        Product_III() { }
        Product_III(string name, decimal price) { Name = name; Price = price; }

        public static List<Product_III> GetSampleList()
        {
            // 可以使用
            return new List<Product_III>
            {
                new Product_III{Name = "huliang",Price = 14.56m },
                new Product_III{Name = "fafa", Price = 9.56m },
                new Product_III{Name = "zhongliu",Price =  65.2m}
            };
        }

        public override string ToString()
        {
            return string.Format("name = {0},price = {1}", Name, Price);
        }



        public static void TestPrint_I()
        {
            foreach (var item in GetSampleList())
            {
                if (item.Price > 10m)
                {
                    Console.WriteLine(item);
                }
            }


            List<Product_III> list = GetSampleList();
            list.Sort((x, y) => (x.Name.CompareTo(y.Name)));
        }


        // 使用 findall + 委托
        public static void TestPrint_II()
        {
            Predicate<Product_III> predicate = delegate (Product_III p) { return p.Price > 10m; };
            List<Product_III> list = GetSampleList().FindAll(predicate);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // 使用 for 循环 条件遍历
        public static void Test()
        {
            List<Product_III> list = Product_III.GetSampleList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort(new ProductNameCompare());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // 使用 ProductNameCompare : IComparer<Product_III>
        public static void TestPrint_IIII()
        {
            List<Product_III> list = GetSampleList();
            list.Sort(new ProductNameCompare());
        }


        // 使用 lambda 表达式
        public static void TestPrint_III()
        {
            List<Product_III> list = GetSampleList();
            list.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
    }

    //class ProductPriceCompare:IComparer<Product_III>
    //{
    //    public int Compare(Product_III x,Product_III y)
    //    {
    //        return x 
    //    }
    //}

}
