using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_面向对象编程_类和对象
{
    class wolf
    {
        public static int wolfcount = 0;
        public string strname;
        public wolf() { wolfcount++; }
        ~wolf() { wolfcount--; }

        public void act()
        {
            if (wolfcount > 5)
            {
                Console.WriteLine("wolf count = {0},attack lion!", wolfcount);
            }
        }

        public void sam()
        {
            wolf[] wolves = new wolf[5];
            for (int i = 0; i < wolves.Length; i++)
            {
                wolves[i] = new wolf();
            }
        }


    }

    class Complex
    {
        public static Complex operator +(Complex z1, Complex z2) { return new Complex(); }
    }

    
    class Cube
    {
        //void test()
        //{
        //    wolf kitty;
        //    kitty.strname = "wolf third";// 使用了未经赋值的局部变量
        //}

        private double length;
        private double width;
        private double height;

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return length;
                    case 1:return width;
                    case 2:return height;
                    default:
                        return 0;
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        length = value;
                        break;
                    case 1:
                        width = value;
                        break;
                    case 2:
                        height = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("下标出界！");
                        
                }
            }
        }
        
    }
}
