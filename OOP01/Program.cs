using OOP01.Class;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            //Explain with code example how class and struct behave differently

            /* struct
             * type : Value type
             * Stored In : Stack
             * Assignment : Copies the data
             * Inheritance :  Not supported
             * Default Constructor : Always exists, cannot be removed
             * Null : Cannot be null (unless nullable)
             * Best For : Small, simple data
             */

            /* Class
             * type : Reference type
             * Stored In : Heap (reference on stack)
             * Assignment : Copies the reference
             * Inheritance : Supported
             * Default Constructor : Provided if none defined
             * Null : Can be null
             * Best For : Complex entities with behavior
             */
            #endregion


            #region Question02
            //Explain the difference between public and private access modifiers with an example. 

            /* public member can be accessed:
             * inside the same class
             * from other classes
             * from other files
             * from other projects (if referenced)
             */

            //Person person = new Person();
            //person.age = 12;


            /* private accessible only inside the same class
             * NOT from other classes
             * NOT from Main()
             * ONLY inside its own class
             */

            //Person person = new Person();
            //person.name = "Yousef";
            #endregion


            #region Question03
            // Describe the steps to create and use a class library in Visual Studio.

            /* Create a Class Library project
             * Write your class in the library
             * Create (or use) another project to use the library
             * Add reference to the Class Library
             * Use the class from the library
             */
            #endregion


            #region Question04
            // What is a class library? Why do we use class libraries?

            // What is a class library -> is a separate project that contains reusable classes, but has no Main method and cannot run on its own. It compiles into a .dll file (Dynamic Link Library).

            // Why do we use class libraries? -> Reusability - Organization - Teamwork - Maintenance 
            #endregion



            #region Part02 Movie Ticket Booking System
            //// ===== Movie Name =====
            //Console.Write("Enter Movie Name: ");
            //string? movieName = Console.ReadLine();

            //// ===== TicketType =====
            //TicketType type;
            //while (true)
            //{
            //    Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            //    int typeNumber;
            //    bool isparsed = int.TryParse(Console.ReadLine(), out typeNumber);

            //    if (isparsed)
            //    {
            //        if (typeNumber == 0 || typeNumber == 1 || typeNumber == 2)
            //        {
            //            type = (TicketType)typeNumber;
            //            break;
            //        }
            //    }

            //}

            //// ===== Seat Row =====
            //char SeatRow;
            //while (true)
            //{
            //    Console.Write("Enter Seat Row (A, B, C...): ");
            //    bool isparsed = char.TryParse(Console.ReadLine() , out SeatRow);
            //    if (isparsed) 
            //    {
            //        if (SeatRow == 'A' || SeatRow == 'B' || SeatRow == 'C')
            //        {
            //            break;
            //        }
            //    }
            //}

            //// ===== Seat Number =====
            //int SeatNumber;
            //while (true)
            //{
            //    Console.Write("Enter Seat Number: ");
            //    bool isparsed = int.TryParse(Console.ReadLine(), out SeatNumber);

            //    if (isparsed)
            //    {
            //        break;
            //    }

            //}

            //// ===== Enter Price =====
            //double Price;
            //while (true)
            //{
            //    Console.Write("Enter Price: ");
            //    bool isparsed = double.TryParse(Console.ReadLine(),out Price);

            //    if (isparsed)
            //    {
            //        break;
            //    }
            //}

            //// ===== Enter Discount =====
            //double Discount;
            //while (true)
            //{
            //    Console.Write("Enter Discount Amount: ");
            //    bool isparsed = double.TryParse(Console.ReadLine() , out Discount);

            //    if (isparsed)
            //    {
            //        break;
            //    }

            //}

            //// ===== create an object from ticket =====
            //Ticket ticket = new Ticket(movieName , type , new Struct.Seat(SeatRow , SeatNumber) , Price);

            //// ===== ticket info =====
            //Console.WriteLine();
            //ticket.PrintTicket();
            //Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14)}");

            //// ===== after Discount =====
            //Console.WriteLine();
            //Console.WriteLine("===== After Discount =====");
            //Console.WriteLine($"Discount Before : {Discount}");
            //ticket.ApplyDiscount(ref Discount);
            //Console.WriteLine($"Discount After  : {Discount}");
            //Console.WriteLine($"Movie       : {ticket.MovieName}");
            //Console.WriteLine($"Type        : {ticket.Type}");
            //Console.WriteLine($"Seat        : {ticket.Seat}");
            //Console.WriteLine($"Price       : {ticket.GetPrice()}");
            //Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14)}");

            #endregion

        }
    }
}
