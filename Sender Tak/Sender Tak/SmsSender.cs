using System;
using System.Collections.Generic;
using System.Text;

namespace Sender_Tak
{
    internal class SmsSender:MessageSender
    {
        public override void messangerSender()
        {
            Console.WriteLine("SmS ile mesaj gonderilmelidir...");
        }
    }
}
