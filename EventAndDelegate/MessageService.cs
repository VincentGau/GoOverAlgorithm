
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MessageService
    {
        public void OnMonitorDone(object source, EventArgs args)
        {
            Console.WriteLine("Sending message...");
        }
    }
}
