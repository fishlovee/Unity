using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_面向对象编程_类和对象
{
    class time
    {
        private int year;
        private int month;
        private int day;
        private int hour;
        private int min;
        private int sec;

        time()
        {
            year = 0;
            month = 0;
            day = 0;
            hour = 0;
            min = 0;
            sec = 0;
        }

        public int Year { get { return year; }  set { year = value; } }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = ((value >= 0 && value < 24) ? value : 0);
                //如果 value 的值合法，就把 value 的值赋给 hour，否则把 0 赋给 hour。
                //请参看第 4 章 4.4.3 节条件表达式
            }
        }
        public string To24String()
        {
            string str24 = "123";

            return str24;
        }
    }
}
