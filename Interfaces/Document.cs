using System;
namespace Interfaces
{
    public class Document: Printable, Storable
    {
        public Document()
        {
        }
        public string DocName { get; set; }
        public void CountCharacters()
        {
            Console.WriteLine("5246 Characters");
        }
        public int Status => 0;

        public void Print()
        {
            Console.WriteLine("Writing Document to printer");
        }

        public string Read()
        {
            Console.WriteLine("Reading from Document");
            return "abs";
        }

        public string Write()
        {
            Console.WriteLine("Writing to Document");
            return "abs";

        }
    }
}
