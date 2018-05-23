using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_多态
{
    abstract class Mamal
    {
        public abstract void Display();
    }

    class Pig : Mamal
    {
        //重写方法：绘图
        public override void Display()
        {
            Console.WriteLine(@" ╭ ︿︿ ☆╮ oοΟ
{/ ． ．\}
( (oo) )
︶︶︶
我是笨猪我怕谁 ");
        }       
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Mamal mal = new Pig();
            mal.Display();

            Console.ReadKey();
        }
    }
}
