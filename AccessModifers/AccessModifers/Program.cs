using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//a way to control access to a class and its members
// encapsulation Encapsulation Inheriance and Polymorphism.
// declares fields as private 
// Provide getter/setter mthods as public.
// from an OOP should hide their implmentation detail and show what they can do. 
// fields are declared as private and the naming convention is undelrine and camel case

namespace AccessModifers
{
    ///Notes. 
    /// 
    /// 
    //public class Person
    //{
    //    private string Name;

    //    public void SetName(string name)
    //    {
    //        if (!String.IsNullOrEmpty(name))
    //            this.Name = name;
    //    }

    //    public string GetName()
    //    {
    //        return Name;

    //    }

    //}
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
             return _birthdate;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
