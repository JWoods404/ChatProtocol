using System;
using System.Collections.Generic;
using System.Text;

namespace ChatProtocol
{
    public class ClientsConnectedMessage : IMessage
    {
        public string Content { get; set; }

        public int MessageId 
        { 
            get { return 5; }
            set { }


        }
    }
}
