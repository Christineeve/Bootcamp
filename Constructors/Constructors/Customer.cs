using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {

        //Generic parameter where we store objects of type order
        public int Id;
        public string Name;                
        public List<Order> Orders;


        //ctor to code snipped for constructor
        // Default and parameterless constructor
        public Customer()
        {
           Orders = new List<Order>();

        }
         
        //overloading constructors.

        //public Customer(int id)
        //    :this()    ///this passes execution to another constructor.

        //{
        //    this.Id = id;

        //}

        //public Customer(int id, string name)
        //    : this(id)
        //{           
        //    this.Name = name;
        //}
    }
}
