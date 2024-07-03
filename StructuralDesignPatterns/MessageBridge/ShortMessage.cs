using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.MessageBridge
{
    public class ShortMessage:Message
    {
        public ShortMessage(MessageSender messageSender) : base(messageSender)
        {
        }

        public override void sendMessage(string message)
        {
            messageSender.send("Short Message: " + message);
        }
    }
}
