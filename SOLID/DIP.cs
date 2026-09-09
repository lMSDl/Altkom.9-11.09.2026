using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    interface IMessage
    {
        void Send();
    }

    class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sending SMS to {PhoneNumber}: {Message}");
        }
    }

    class Mms : IMessage
    {
        public string PhoneNumber { get; set; }
        public byte[] Message { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sending MMS to {PhoneNumber}: {Encoding.UTF8.GetString(Message)}");
        }
    }

    class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sending Email to {EmailAddress}: Subject: {Subject}, Body: {Body}");
        }
    }

    class Messanger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messanger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }

        public void Send(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            Send();
        }   

        public void Send()
        {
            foreach (var message in Messages)
            {
                message.Send();
            }
        }
    }
}
