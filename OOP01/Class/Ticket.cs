using OOP01.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.Class
{
    public class Ticket
    {
        public string? MovieName;
        public TicketType Type;
        public Seat Seat;
        private double Price;

        public Ticket() 
        {
            MovieName = "Inception";
            Type = TicketType.Standard;
            Seat = new Seat('A' , 1);
            Price = 50;
        }

        public Ticket(string? movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }


        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
            Console.WriteLine($"Seat     : {Seat}");
            Console.WriteLine($"Price    : {Price}");
        }

        public double GetPrice() { return Price; }

    }
}
