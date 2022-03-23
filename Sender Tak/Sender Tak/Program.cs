using System;

namespace Sender_Tak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit");
            Console.Write("Enter number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            EmailSender Esend = new EmailSender();
            SmsSender Ssend = new SmsSender();

            switch (Number)
            {
                case 1:
                    Esend.messangerSender();
                    break;
                case 2:
                    Ssend.messangerSender();
                    break;
                case 0:
                    Console.WriteLine("Finish...");
                    break;

                default:
                    Console.WriteLine("Zehmet olmasa GOSTERILEN reqemlerden birini secin...");
                    break;
            }
        }
    }
}
