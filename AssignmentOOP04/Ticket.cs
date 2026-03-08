namespace AssignmentOOP04
{
    public class Ticket
    {
        public int TicketId { get; }
        public string MovieName { get; set; }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value;
            }
        }
        private static int ticketCounter = 0;
        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Price = price;

        }

        public decimal PriceAfterTax => Price * 1.14m;

        public static int GetTotalTickets() => ticketCounter;

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        public void SetPrice(decimal price) 
        {
            Console.WriteLine($"Setting Price Directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier) 
        {
            decimal Price = basePrice * multiplier; 
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }
    }
}

