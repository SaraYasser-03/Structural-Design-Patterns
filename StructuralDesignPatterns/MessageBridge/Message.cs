using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.MessageBridge
{
    public abstract class Message
    {
        protected MessageSender messageSender;

        public Message(MessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public abstract void sendMessage(string message);
    }
}
