using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals3
{
    //Class 
    public class Person
    {
        public int Age;
    }
        
    
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            var number = 1;
            //copy is taken and sent to the increment method.
            Increment(number);

            var person = new Person() {Age =20};
            MakeOld(person);
            Console.WriteLine(person.Age);
            
        }

        //Call them without a need to not create an object.
        public static void Increment(int number)
        {
            number += 10;
        }

        //by reference, the memory location on the heap
        public static void MakeOld(Person person)
        {
             person.Age += 10;        
        }
          
    }
}
