using System;
using System.Collections.Generic;
using System.Text;

namespace Sender_Tak
{
    internal class EmailSender:MessageSender
    {
        public override void messangerSender()
        {
            Console.WriteLine("Email ile masaj gonderilmelidir...");
        }
    }
}
