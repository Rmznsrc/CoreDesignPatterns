using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator:Decorator
    {
        private readonly ISendMesssage _sendMessage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMesssage sendMesssage) : base(sendMesssage)
        {
            _sendMessage = sendMesssage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
            
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach(var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item+3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageByEncryptoSubject(message);
        }

    }
}
