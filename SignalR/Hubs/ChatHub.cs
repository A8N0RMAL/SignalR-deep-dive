using Microsoft.AspNetCore.SignalR;
using SignalR.Data;
using SignalR.Models;

namespace SignalR.Hubs
{
    public class ChatHub(ChatDbContext context) : Hub
    {
        private readonly ChatDbContext _context = context;
        // Define services/methods that can be called by the clients

        [HubMethodName("sendMessage")]
        public void SendMessage(string name, string message)
        {
            // save into DB 
            ChatMessage chatMessage = new ChatMessage
            {
                UserName = name,
                Message = message
            };

            _context.ChatMessages.Add(chatMessage);
            _context.SaveChanges();

            // broadcasting to all online clients 
            Clients.All.SendAsync("newMessage", name, message); // newMessage -> Call Back function in JS

        }
        
        [HubMethodName("joinGroup")]
        public void JoinGroup(string groupName, string name)
        {
            // Add user to group using its ConnectionId.
            Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            // Broadcast to all group members Except the new user that a new user joined.
            Clients.OthersInGroup(groupName).SendAsync("newMember", name, groupName);
            // newMember -> Call Back function in JS
        }

        [HubMethodName("sendMessageToGroup")]
        public void SendMessageToGroup(string groupName, string name, string message)
        {
            // Broadcast to all group members including the sender.
            Clients.Group(groupName).SendAsync("newGroupMessage", groupName, name, message);
            // newMessage -> Call Back function in JS
        }
        #region Hub Life Cycle Events
        override public Task OnConnectedAsync()
        {
            string connectionId = Context.ConnectionId;

            Console.WriteLine($"A user connected to the chat with ConnectionId '{connectionId}'.");
            return base.OnConnectedAsync();
        }
        override public Task OnDisconnectedAsync(Exception? exception)
        {
            string connectionId = Context.ConnectionId;
            Console.WriteLine($"A user disconnected from the chat with ConnectionId '{connectionId}'.");
            return base.OnDisconnectedAsync(exception);
        }
        #endregion

    }
}
