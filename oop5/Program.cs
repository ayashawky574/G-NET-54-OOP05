using ConsoleApp1;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            //Q1:
            //What is an interface in C#?
            // interface define contract that class must follow it define what class do and how to do it
            //Why do we use interfaces instead of depending on concrete classes directly?
            // use conceret class cuases tight coupling - hard to change - hard testing
            //Mention at least three benefits of using interfaces.
            //1- enabling multiple inheritance
            //2- enabling polymorphism without inheritance
            //3- remvoe tight coupling
            #endregion

            #region Q2
            //    interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello / Ahlan");
            //    }
            //}


            //a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            //-we have 2 interfaces both have same method signature with one implementation in the class 
            //-class will implement one method for both interfaces / both interface references will call the same implementation

            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan" ?
            //    What is this technique called ?
            //    class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void IEnglishSpeaker.Greet()
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //    public void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine("Ahlan");
            //    }
            //}
            //Explicit interface implementation

            //c) After applying your fix, can you call Greet() directly on a Translator object(e.g.translator.Greet()) ?
            //Why or why not? How do you call each version ?
            // no , explicit members hidden from class refernce
            // each explicit members being caleed with its interface reference 
            #endregion

            #region Q3
            //Q3: Explain the difference between a shallow copy and a deep copy
            // shallow : copy object but reference for reference type fields
            //deeep : copy object ans inner objects creating independant objects

            //.When would you use each one?
            //shalow : no nested reference types ,object is immutable ,performance is critical
            // Deep : object is isolated , changes dont effect the original

            //What is the risk of using a shallow copy when the object has reference - type fields ?
            // changing inner object affects two copies 
            #endregion

            #region Q4

            //var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //var e2 = e1.ShallowCopy();
            //e2.Title = "QA";
            //e2.Dept.Name = "Testing";

            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            //// Dev - Testing
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");
            ////QA -Testing
            //// as two objects has same inner references changing inner object effect both copies
            #endregion
            #endregion

            #region Part02
            //// a. Create a Cinema and open it.
            //Cinema cinema = new Cinema("your cinema");
            //cinema.openCinema();
            ////b. Create one of each ticket type with hardcoded data.
            ////Book all three and add them to the Cinema.
            //StandardTicket t1 = new StandardTicket(
            //                        "Inception ",
            //                        TicketType.Standard 
            //                        , new SeatLocation('A' , 1) ,
            //                        80 ,
            //                        "1"
            //                        );
            //VIPTicket t2 = new VIPTicket("Avengers",
            //    TicketType.VIP,
            //    new SeatLocation('A', 2),
            //    200,
            //    true);
            //IMAXTicket t3 = new IMAXTicket(
            //    "Dune",
            //    TicketType.IMAX,
            //    new SeatLocation('A', 3),
            //    130,
                
            //    true);
            //t1.Book();
            //t2.Book();
            //t3.Book();
            
            //cinema.AddTicket(t1);
            //cinema.AddTicket(t2);
            //cinema.AddTicket(t3);

            ////c.Print all tickets through the Cinema.
            //Console.WriteLine();
            //Console.WriteLine("=========== All Tickets ==========");
            //cinema.Print();

            ////d.Clone a VIP ticket, change the clone's movie name, and print both to prove independence.
            //Console.WriteLine();
            //Console.WriteLine("========= clone Test =========");
            ////Console.WriteLine($"original :{t2}");
            //VIPTicket t4 =(VIPTicket) t2.Clone();
            
            ////Console.WriteLine($"Clone : {t4}");
            //t4.MoveiName = "Interstellar";
            //Console.WriteLine($"original :{t2}");
            //Console.WriteLine($"Clone : {t4}");
            //Console.WriteLine(t4.TicketId);
            //Console.WriteLine();
            ////e.Cancel one ticket and reprint it to show the updated status.
            //Console.WriteLine("========= After Cancellation =======");
            //t1.Cancell();
            //Console.WriteLine(t1);
            //Console.WriteLine();

            ////f.Use the utility method to print an array of printable tickets.
            //Console.WriteLine("======== Booking Helper . PrintAll =======");
            //Ticket[] tickets = [t1, t2, t3];
            //BookingHelper.PrintTicket(tickets);
            //Console.WriteLine();
            //cinema.closeCinema();
            #endregion
        }
    }
    
}
