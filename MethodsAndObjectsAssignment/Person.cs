using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
   //     Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.

   //Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”.
        public string FirstName; 
        public string LastName;



        public void SayName()
        {
            string FullName = FirstName +" " + LastName;
            Console.WriteLine("Name: " + FullName
           );

        }
    }
}

