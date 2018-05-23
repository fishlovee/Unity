using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_boxing
{
    class StoreHouse
    {
        public object[] items;
        private int count;

        public StoreHouse(int c)
        {
            items = new object[c];
            count = c;
        }

        void Add(object obj)
        {
            if (count < items.Length)
            {
                items[count++] = obj;
            }
            else
            {
                Console.WriteLine("仓库已满！");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
