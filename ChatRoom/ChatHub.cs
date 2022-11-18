using Microsoft.AspNetCore.SignalR;

namespace ChatRoom
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message); 
        }

        public async Task AddToGroup(string room, string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowWho", $"{DateTime.Now:dd/MMM HH:mm:ss} - Se conectó {user} : {Context.ConnectionId}");

        }
    }
}
