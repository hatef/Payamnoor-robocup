using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class MessageCommander
    {
        public static void SayMessage(string message)
        {
            if (message.Length <= 20)
                Server.Message(string.Format("(message {0})", message));
        }
        private static string hearMessage;

        public static string HearMessage
        {
            get { return MessageCommander.hearMessage; }
            set { MessageCommander.hearMessage = value; }
        }
    }
}
