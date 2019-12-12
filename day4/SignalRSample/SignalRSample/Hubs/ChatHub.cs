using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Broadcast", "server",
                $"a new client connected {this.Context.ConnectionId}");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("Broadcast", "server",
                $"client {this.Context.ConnectionId} disconnected, {exception.GetType().Name}");
            await base.OnDisconnectedAsync(exception);
        }

        public async Task MyMessage(string user, string message)
        {
            await base.Clients.All.SendAsync("Broadcast", user, message);
        }
    }
}
