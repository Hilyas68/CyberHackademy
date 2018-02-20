using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Generic
{
    class MessageService<T> : INotificationService<T> where T : Message
    {
        public void SendBulkMessage(string[] recipients, string sender, string message)
        {
            foreach (var receipient in recipients)
            {
                Console.WriteLine($"Sending {message} from {sender} to {receipient}");
            }
        }

        public void SendSingleMessage(string recipient, string sender, string mesage)
        {
            Console.WriteLine($"sending {mesage} from {sender} to {recipient}");
        }

        public void SendBulkMessage(T[] msgs)
        {
            foreach (var msg in msgs)
            {
                Console.WriteLine($"Sending {msg.MsgContent} from {msg.Sender} to {msg.Receipient}");
            }
        }
    }

    interface INotificationService<T>
    {
        void SendSingleMessage(string recipient, string sender, string mesage);

        void SendBulkMessage(string[] recipients, string sender, string message);

        void SendBulkMessage(T[] msg);
    }
}
