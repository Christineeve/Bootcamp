using System;

namespace Inhertitance
{
    public class Text : PresentationObject

    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHpyerlink(string url)
        {
            Console.WriteLine("We added a link to "+ url);
        }

    }
}