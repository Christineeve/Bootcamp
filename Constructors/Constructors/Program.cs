using System;
using System.Collections.Generic;

//  Constructor is a method that is called when an instance of a class is created.
//  A constructor has the exact same name as the class this is a requirement.
//  A constructor does not have a return type, not even void. You can initalize upon creation.
//  public class Customer
//   {
 //       public Customer()  // no paramaters "parameterless" it will be in the IL 
//          {
//              public string Name;
//              public Customer(string name)
//              {
//                 this makes sure of what we have on the left side of the assignment operator, the constructor parameter is copied.
//                  this.Name = name;
//              }
//          }
//   }
// Overloading means having a method by the same name with different signatures
// to make initalization of the class easier. 
namespace Constructors
{
   class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";
           
            var order = new Order();
          //  customer.Orders = new List<Order>();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

   
        }
    }
}
