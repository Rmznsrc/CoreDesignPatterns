using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMesssage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMesssage sendMesssage) : base(sendMesssage)
        {
            _sendMessage = sendMesssage;
        }
        public void SendMessageIDSubject(Message message)
        {
            if(message.MessageSubject == "1")
            {
                message.MessageSubject = "Toplantı";
            }else if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Toplantısı";
            }
            else if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Haftalık Değerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageIDSubject(message);
        }
    }
}
