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



        }
    }
}
