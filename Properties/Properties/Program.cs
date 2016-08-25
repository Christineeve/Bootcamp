using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// property is a class member that encapsulates a getter/setter for accessing a field.
namespace Properties
{
    public class Person
    {
        //Auto-Implement Prooperties
        public DateTime Birthdate { get; set; }

        //private DateTime _birthdate;

            //public DateTime Birthdate
            //{

            //    get { return _birthdate; }
            //    set { _birthdate = value; }

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
