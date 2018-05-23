using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 处理未知数据
{
    class UnknowPrice
    {
        public string Name { get; private set; }
        public decimal? Price { get; private set; }
        public UnknowPrice(string name,decimal? price = null)
        {
            Name = name;
            Price = price;
        }
    }


}
