namespace AssignmentOOP04
{
    public class IMAXTicket : Ticket
    {
        public bool IS3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            IS3D = is3d;

            if(IS3D)
            {
                Price += 30m;
            }
        }

        public override void PrintTicket()
        {
           base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(IS3D ? "Yse" : "No")}");
        }
    }
}
