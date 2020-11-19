namespace ChatProtocol
{
    public class DisconnectMessage : IMessage
    {
        public string ClientUsername { get; set; }
        public string ClientPassword { get; set; }
        public string SessionId { get; set; }
        public int MessageId
        {
            get
            {
                return 3;
            }
            set { }
        }
    }
}
