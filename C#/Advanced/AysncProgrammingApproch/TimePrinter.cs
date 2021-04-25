﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysncProgrammingApproch
{
    public class TimePrinter
    {
        public void Print() 
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromMinutes(.10);

            while (DateTime.UtcNow - startTime < future) 
            {
                Debug.WriteLine("delay : " + DateTime.Now.ToString("hh:MM:ss"));
            }

            Debug.WriteLine("delay over");
        }

        public Task<int> PrintAsync() 
        {
            return Task.Run(() => {
                Print();
                return 10;
            });
        }
    }
}
