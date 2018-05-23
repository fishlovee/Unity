using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Delegates_and_Events
{
    class Circus
    {
       public  delegate void Display(string strMsg);
       public static void DogDisplay(string strMsg)
        {
            Console.WriteLine("我是Snoopy，{0}！", strMsg);
        }
        public static void CatDisplay(string strMsg)
        {
            Console.WriteLine("我是Hellocaty，{0}！", strMsg);
        }
        public static void MiseDisplay(string strMsg)
        {
            Console.WriteLine("我是Micky，{0}！", strMsg);
        }

        public static void CircusStart(Display display, string msg)
        {
            display(msg);
        }

        public static void CircusStartII(Display display, string msg)
        {
            display(msg);
        }
    }

 
    class Program
    {
        
        static void Main(string[] args)
        {
            //Circus.Display play = new Circus.Display(Circus.DogDisplay);
            //play += new Circus.Display(Circus.CatDisplay);
            //play += Circus.MiseDisplay;
            //Circus.CircusStart(play,"good even!");
            //Circus.CircusStart(Circus.DogDisplay,"GOOD Morning!");

            Dog dog = new Dog();
            Host host = new Host(dog);
            DateTime now = new DateTime(2011, 12, 31, 23, 59, 55);
            DateTime midnight = new DateTime(2012, 1, 1, 0, 0, 0);
            Console.WriteLine("时间一秒一秒地流逝，等待午夜的到来... ");
            while (true)
            {
                Console.WriteLine("当前时间: " + now);
                //午夜零点小偷到达,看门狗引发 Alarm 事件
                if (now == midnight)
                {
                    Console.WriteLine("\n 月黑风高的午夜, 小偷悄悄地摸进了主人的屋内...");
                    //引发事件
                    Console.WriteLine("\n 狗报警: 有小偷进来了,汪汪~~~~~~~");
                    dog.OnAlarm();
                    break;
                }
                System.Threading.Thread.Sleep(1000); //程序暂停一秒
                now = now.AddSeconds(1); //时间增加一秒
            }
            Console.ReadKey();       
        }
    }
}
