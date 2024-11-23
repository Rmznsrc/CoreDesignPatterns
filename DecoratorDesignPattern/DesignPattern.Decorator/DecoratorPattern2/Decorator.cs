using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMesssage
    {
        private readonly ISendMesssage _sendMesssage; 
        public Decorator(ISendMesssage sendMesssage)
        {
            _sendMesssage = sendMesssage;
        }

        virtual public void SendMesssage(Message message)
        {
            message.MessageReceiver = "Everybody";
            message.MessageSender = "Admin";
            message.MessageContent = "Merhaba, bu bir toplantı mesajıdır.";
            message.MessageSubject = "Toplantı";
            _sendMesssage.SendMesssage(message);
        }
    }
}
