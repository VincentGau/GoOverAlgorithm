using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MonitorEventArgs : EventArgs
    {
        public int MyProperty { get; set; }
    }


    public class Monitor
    {

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise event
        
        public event EventHandler<MonitorEventArgs> MonitorDone;

        public void ProcessMonitor()
        {
            Console.WriteLine("Processing monitor...");
            Thread.Sleep(2000);

            OnMonitorDone(123);
        }

        protected virtual void OnMonitorDone(int param)
        {
            MonitorDone?.Invoke(this, new MonitorEventArgs() { MyProperty = param });
        }
    }
}
