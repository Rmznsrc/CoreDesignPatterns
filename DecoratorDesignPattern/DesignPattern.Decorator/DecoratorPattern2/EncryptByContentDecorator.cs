using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMesssage _sendMessage;
        Context context = new Context();
        public EncryptByContentDecorator(ISendMesssage sendMesssage) : base(sendMesssage)
        {
            _sendMessage = sendMesssage;
        }
        public void SendMessageByEncryptoContentSubject(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 17:00'de publish yapılacak.";
            message.MessageSubject = "Publish";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageByEncryptoContentSubject(message);
        }
    }
}
