using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.MessageBridge
{
    public class Sms : MessageSender
    {
        public void send(string messageText)
        {
            Console.WriteLine(messageText);
        }
    }
}
