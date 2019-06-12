
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MessageService
    {
        public void OnMonitorDone(object source, MonitorEventArgs args)
        {
            Console.WriteLine($"Sending message... {args.MyProperty}");
        }
    }
}
