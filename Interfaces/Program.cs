using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Document myDoc = new Document();
            myDoc.Print();
            myDoc.CountCharacters();

            Printable mydoc2 = new Document();
            mydoc2.Print();
            //mydoc2.CountCharacters(); -> this won't work
            Document mydoc3 = mydoc2 as Document; //casting
            mydoc3.CountCharacters();

            Console.WriteLine("Contents: " + mydoc3.Read());
        }
    }
}
