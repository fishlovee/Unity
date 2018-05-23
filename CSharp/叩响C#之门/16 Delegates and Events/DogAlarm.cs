using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Delegates_and_Events
{
    class Dog
    {
        public delegate void AlarmEventHandler(object sender, EventArgs e);
        public event AlarmEventHandler Alarm;

        public void OnAlarm()
        {
            if (this.Alarm != null)
            {
                this.Alarm(this, new EventArgs());
            }
        }
    }

    class Host
    {
        public void HostHandlerEvent(object sender,EventArgs e)
        {
            Console.WriteLine("主任，抓小偷了");
        }

        public Host(Dog d)
        {
            d.Alarm += new Dog.AlarmEventHandler(HostHandlerEvent);
        }
    }
}
