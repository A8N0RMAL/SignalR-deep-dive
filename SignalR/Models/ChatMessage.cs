namespace SignalR.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Message {  get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
