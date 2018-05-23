using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
enum COLORS
{
    RED = 1,
    GREEN = 5,
}
namespace 枚举_结构体和数组
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一维数组
            int[] score = { 68, 97, 45, 67 };
            int len = score.Length;
            string[] friendnames = new string[3];

            string[] friendNames = { "张三", "李四", "王五" };
            //Console.WriteLine("我共有{0}位朋友：", friendNames.Length);
            //foreach (string name in friendNames)
            //{
            //    Console.WriteLine(name);
            //}

            // 二维数组
            int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int sum = 0;
            foreach (int number in Matrix)
            {
                sum += number;
            }
            Console.WriteLine("sum = {0}", sum);
            // 

            int[,] Matrix2 = new int[3, 3];


            // 可变数组
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[3]; //初始化第一行，3 个元素
            jaggedArray[1] = new int[4]; //初始化第二行，4 个元素
            foreach (int[] line in jaggedArray)
            {
                foreach (int element in line)
                {
                    Console.Write(element);
                }
            }


            Console.ReadKey();
        }
    }
}
