using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_面向对象编程_类和对象
{
    /// <summary>
    /// 
    /// </summary>
    class Cat
    {
        public string name;
        public int age;
        private int miceCount = 0; //用于记录捉到了多少只老鼠

        private void Hello()
        {
            Console.Write("嗨，我是{0},", name);
        }

        //方法：喵喵叫
        public void Meow()
        {
            Hello();
            Console.WriteLine("喵，喵~~~~");
        }

        //方法：捉老鼠
        public void ChaseMice()
        {
            miceCount++;
            Hello();
            Console.WriteLine("我已经抓住了{0}只老鼠!", miceCount);
        }

        void test()
        {
            Cat someone; //声明类型为 Cat 的引用符
            Cat kitty = new Cat("Kitty", 3); //创建对象 kitty
            Cat garefield = new Cat("Garefield ", 5); //创建对象 garfield
                                                      //让引用符 someone 指向对象 kitty
            someone = kitty;
            Console.WriteLine("嗨，我是{0},我有{1}岁了。", someone.name, someone.age);
            //让引用符 someone 指向对象 Garifiel
            someone = garefield;
            Console.WriteLine("嗨，我是{0},我有{1}岁了。", someone.name, someone.age);
            Cat[] cats = new Cat[5];
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = new Cat("cat" + i, i);
            }

            var city = new { Name = "Beijing", ZipCode = 100000 };
            Console.WriteLine("Name={0}\nZipCode={1}", city.Name, city.ZipCode);
        }


            Cat(string strName = "kitty",int nage = 0)
        {
            name = strName;
            age = nage;
        }

        void init()
        {
            Cat doraemon = new Cat { name = "Doraemon",age = 8};
            
            Cat kitty = new Cat();
            kitty.age = -10;
            Cat doraemon2 = new Cat { name = "Doraemon", age = 8 };
        }
    }

    class B
    {
        //public sealed override void F(){ }//密封方法
    }
}
