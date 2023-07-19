using Microsoft.AspNet.SignalR;

namespace SignalRWeb
{
    public class ChatHub : Hub
    {
        public void SendMessage(string user, string message)
        {
            // Broadcast the message to all connected clients
            Clients.All.BroadcastMessage(user, message);
        }
    }
}