using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        { 
            Message message         = new Message();
            message.MessageContent  = "Bu bir content mesajıdır.";
            message.MessageSender   = "Admin IK";
            message.MessageReceiver = "Herkes";
            message.MessageSubject  = "Deneme yapıyoruz.";

            CreateNewMessage createNewMessage = new CreateNewMessage(); 
            createNewMessage.SendMesssage(message);
            return View();
        }
        public IActionResult Index2()
        {
            Message message = new Message();
            message.MessageContent = "Bu bir Subject şifreli mesajıdır.";
            message.MessageSender = "Team Lead";
            message.MessageReceiver = "Herkes";
            message.MessageSubject = "Merhaba";
            CreateNewMessage createNewMessage = new CreateNewMessage();
            EncryptoBySubjectDecorator encryptoBySubjectDecorator = new EncryptoBySubjectDecorator(createNewMessage);
            encryptoBySubjectDecorator.SendMessageByEncryptoSubject(message);
            return View();
        }
    }
}
