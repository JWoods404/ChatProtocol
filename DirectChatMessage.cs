using System;
using System.Collections.Generic;
using System.Text;

namespace ChatProtocol
{
    class DirectChatMessage : IMessage
    {
        public string Content { get; set; }
        public string SessionId { get; set; }
        public string Username { get; set; }
        public int UserId { get; set; }
        public int ToUserId { get; set; }

        public int MessageId
        {
            get { return 9; }
            set { }
        }
    }
}
