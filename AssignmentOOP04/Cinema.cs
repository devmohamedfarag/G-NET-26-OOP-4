namespace AssignmentOOP04
{
    public class Cinema
    {
        public string CinemaName { get; set; }
        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }
        
        private Ticket[] tickets = new Ticket[20];

        public void PrintAllTickets()
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null)
                {
                    ticket.PrintTicket();
                }
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n============ Process Single Ticket=========");
            t.PrintTicket();
        }

        public void OpenCinema()
        {
            Console.WriteLine("\n======== Cinema Opened ========");
            Console.WriteLine("Projector started.");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n======== Cinema Closed ========");
            Console.WriteLine("Projector Stopped.\n");
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
            Console.WriteLine("Cinema is full. Cannot add more tickets.");
        }
    }
}
