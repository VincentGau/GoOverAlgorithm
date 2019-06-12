﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();
            MessageService messageService = new MessageService();

            monitor.MonitorDone += messageService.OnMonitorDone;

            monitor.ProcessMonitor();
        }
    }
}
