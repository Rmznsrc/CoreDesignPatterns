using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Salih Yıldız";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteri Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Salih Yıldız";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Maksimum Çekebileceği Tutar 400.000₺ Olup Daha Fazlası İçin Birden Fazla Gün Şubeye Gelmesi Gerekli.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
