﻿namespace ChatProtocol
{
    public class ChatMessage : IMessage
    {
        public string Content { get; set; }
        public string Username { get; set; }

        public int MessageId
        {
            get
            {
                return 1;
            }
            set { }
        }
    }
}