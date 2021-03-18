using System;

namespace _4._2
{
    public delegate void ClockHandler(object sender, ClockArgs args);

    public class ClockArgs{
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Second { get; set; }
    }

    public class Clock
    {
        private int hour, minute, second, hourSet, minuteSet, secondSet;
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        public Clock()
        {
            hour = int.Parse(DateTime.Now.Hour.ToString());
            minute = int.Parse(DateTime.Now.Minute.ToString());
            second = int.Parse(DateTime.Now.Second.ToString());
        }

        public void SetAlarm(int hour, int minute,int second)
        {
            hourSet = hour;
            minuteSet = minute;
            secondSet = second;
        }

        public void SetAlarm(int hour, int minute)
        {
            hourSet = hour;
            minuteSet = minute;
            secondSet = 0;
        }

        public void RunClock()
        {
            while (true)
            {
                this.hour = int.Parse(DateTime.Now.Hour.ToString());
                this.minute = int.Parse(DateTime.Now.Minute.ToString());
                this.second = int.Parse(DateTime.Now.Second.ToString());
                ClockArgs TimeNow = new ClockArgs() { Hour = hour.ToString(), Minute = minute.ToString(), Second = second.ToString() };
                if (TimeNow.Hour.Length == 1)
                    TimeNow.Hour = "0" + TimeNow.Hour;
                if (TimeNow.Minute.Length == 1)
                    TimeNow.Minute = "0"+ TimeNow.Minute;
                if (TimeNow.Second.Length == 1)
                    TimeNow.Second = "0"+ TimeNow.Second;
                if (this.hour == this.hourSet && this.minute == this.minuteSet && this.second == this.secondSet)
                {
                    Alarm(this, TimeNow);
                }
                else
                    Tick(this, TimeNow);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class NewClock
    {
        public Clock ClockTemp;
        public NewClock()
        {
            ClockTemp = new Clock();
            ClockTemp.Tick += Tick;
            ClockTemp.Alarm += Alarm;
        }
        void Tick(object sender, ClockArgs args)
        {
            Console.WriteLine("TickEvent：" + args.Hour + ":" + args.Minute + ":" + args.Second);
        }
        void Alarm(object sender, ClockArgs args)
        {
            Console.WriteLine("AlarmEvent:" + args.Hour + ":" + args.Minute + ":" + args.Second);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewClock Clock = new NewClock();
            Console.WriteLine("Enter the time to set:");
            string str = Console.ReadLine();
            string[] strs = str.Split(":");
            if(strs.Length == 2)
            {
                Clock.ClockTemp.SetAlarm(int.Parse(strs[0].ToString()), int.Parse(strs[1].ToString()));
            }
            else
                Clock.ClockTemp.SetAlarm(int.Parse(strs[0].ToString()), int.Parse(strs[1].ToString()), int.Parse(strs[2].ToString()));
            Clock.ClockTemp.RunClock();
        }
    }
}
