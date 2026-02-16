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


        }
    }
}
