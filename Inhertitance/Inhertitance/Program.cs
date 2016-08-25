

namespace Inhertitance
{
     //C# can have only one parent. 
    // Object class is the Parent of all classes.
    // allows code reuse.

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();



        }
    }
}
