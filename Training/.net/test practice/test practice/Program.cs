using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_practice
{
    class TicketsException : ApplicationException
    {
        public TicketsException(string s) : base(s)
        {

        }
    }
    class Passanger
    {
        public string Name;
        public int Age;
        public string DateofTravel;
        public int no_of_tickets;
        public Passanger(string Name, int Age, string DateofTravel)
        {
            this.Name = Name;
            this.Age = Age;
            this.DateofTravel = DateofTravel;
            Console.WriteLine("Name of passenger" + Name + " age is " + 21 + " date of travel is " + DateofTravel);
        }
        public static void TicketBooking(int no_of_tickets)
        {
            Console.WriteLine("no of ticket;");
            no_of_tickets = Convert.ToInt32(Console.ReadLine());
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("Cannot book more than 5 tickets!!!"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully!!!");
            }
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Passanger passanger = new Passanger("Manoj", 22, "25/05/2022");
            try
            {
                Passanger.TicketBooking(6);
            }
            catch (TicketsException t)
            {
                Console.WriteLine(t.Message);
            }
            Console.ReadLine();
        }

    }
}
