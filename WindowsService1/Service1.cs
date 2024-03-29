﻿using System;
using System.ServiceProcess;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1
    {
        private readonly Timer timer1;
        public Service1()
        {
            timer1 = new Timer
            {
                Enabled = false,
                Interval = 500
            };
            timer1.Elapsed += Timer1_Elapsed; 
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Elapsed: {DateTime.Now.ToLongTimeString()}");
        }

        public void OnStart(string[] args)
        {
            timer1.Enabled = true;
        }

        public void Dispose()
        {
            timer1.Enabled = false;
        }
    }
}
