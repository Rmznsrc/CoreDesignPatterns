using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class CreateNewMessage : ISendMesssage
    {
        Context context = new Context();
        public void SendMesssage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
