
#region Question01:
// Q1 : What is the difference between static binding and dynamic binding? When does each one happen?
//
//Asnwer: Static binding: means the method call is resolved at compile time. The compiler already knows which method will be executed.
//      * When it happens:
//        Method overloading.
//        Static methods.
//        Private methods.
//        Final/Sealed methods.
//        When a method is not overridden.
//
//       Dynamic binding: means the method call is resolved at runtime. The program decides which method to execute while running.
//      * When it happens:
//        Method overriding.
//        Virtual methods.
//        Abstract methods.
//        Polymorphism.
#endregion

#region Question02:
// Q2: What is the difference between method overloading and method overriding?

//Answer: Method overloading: is when you have multiple methods in the same class with the same name but different parameters (different type, number, or order of parameters).

//        Method overriding: is when a subclass provides a specific implementation of a method that is already defined in its superclass.
#endregion

#region Qusetion03:
// Q3: What keywords are used for Method Overriding? What does each one mean ?

//Answer: The keywords used for method overriding are:.
//        * virtual: is used in the base class to indicate
//          that a method can be overridden in a derived class.
//        * override: is used in the derived class to indicate
//          that a method is overriding a virtual method in the base class.
#endregion

#region Part02: Ticket Booking System
namespace AssignmentOOP04
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Cinema Name: ");
            string cinemaName = Console.ReadLine();
           
            Cinema cinema = new Cinema(cinemaName);

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 150, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            Console.WriteLine("\n=============== SetPrice Test=============");
            t1.SetPrice(150);
            t1.SetPrice(100, 1.5m);

            Console.WriteLine("\n=============== All Tickets =============");
            cinema.PrintAllTickets();

            Cinema.ProcessTicket(t2);

            cinema.CloseCinema();
           
            Console.ReadKey();
        }
    }
}
#endregion