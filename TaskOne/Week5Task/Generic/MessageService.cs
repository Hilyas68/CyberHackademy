﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Generic
{
    class MessageService<T> : INotificationService<T>
    {
        public void SendBulkMessage(string[] recipients, string sender, string message)
        {
            throw new NotImplementedException();
        }

        public void SendSingleMessage(string recipient, string sender, string mesage)
        {
            throw new NotImplementedException();
        }
    }

    interface INotificationService<T>
    {
        void SendSingleMessage(string recipient, string sender, string mesage);

        void SendBulkMessage(string[] recipients, string sender, string message);
    }
}
