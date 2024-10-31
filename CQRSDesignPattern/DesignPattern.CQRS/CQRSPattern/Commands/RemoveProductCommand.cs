namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
    }
}
