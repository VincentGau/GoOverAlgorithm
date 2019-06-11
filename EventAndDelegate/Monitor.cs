using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class Monitor
    {

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise event

        public delegate void MonitorEventHandler(object source, EventArgs args);

        public event MonitorEventHandler MonitorDone;

        public void ProcessMonitor()
        {
            Console.WriteLine("Processing monitor...");
            Thread.Sleep(2000);

            OnMonitorDone();
        }

        protected virtual void OnMonitorDone()
        {
            MonitorDone?.Invoke(this, EventArgs.Empty);
        }
    }
}
