using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
//            Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.

//Call the superclass method SayName() on the Employee object.
            Employee Person01 = new Employee();
            Person01.FirstName = "Sample";
            Person01.LastName = "Student";
            Person01.SayName();

        
        }
    }
}
