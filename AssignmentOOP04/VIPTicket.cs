namespace AssignmentOOP04
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public const decimal ServiceFee = 50m; 

        public VIPTicket(string movieName, decimal price, bool loungeAccess): base( movieName,  price)
        {
            LoungeAccess = loungeAccess;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge Access: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
}
