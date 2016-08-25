using System;

namespace Classes
{
   public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

       //declare this object as static modifer so we don't have to create a person object in order to parse the string below.
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }

        }

    class Program    
    {

        static void Main(string[] args)
        {            
            //use the person class to parse the string and now we have a person object.
            var person = Person.Parse("John");            
            person.Introduce("Mosh");

        }
    }
}
