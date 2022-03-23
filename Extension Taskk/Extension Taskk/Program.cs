using Extension_Taskk.Extentions;
using System;

namespace Extension_Taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Bu bir custom contains methodudur";
            Console.WriteLine("1. " + sentence.customContains("Bu"));
            Console.WriteLine("2. " + sentence.customContains("bu"));
            Console.WriteLine("3. " + sentence.customContains("tains"));
            Console.WriteLine("4. " + sentence.customContains("ns Methodudur"));
            Console.WriteLine("5. " + sentence.customContains("bu bir custom"));
            Console.WriteLine("6. " + sentence.customContains("Bunlar"));
            Console.WriteLine("7. " + sentence.customContains("Costims"));
            Console.WriteLine("8. " + sentence.customContains("metodu"));
            Console.WriteLine("9. " + sentence.customContains("u b"));
            Console.WriteLine("10. " + sentence.customContains("z"));
            Console.WriteLine("11. " + sentence.customContains("r"));
            Console.WriteLine("12. " + sentence.customContains(" "));



        }
    }
}
