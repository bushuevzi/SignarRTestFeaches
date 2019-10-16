using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignarRTestFeaches.Hubs
{
    public class ChatHub : Hub
    {
        // Этот метод могут дернуть любые пользователи которые подключились по WebSocket
        public async Task SendMessage(string user, string message)
        {
            // Сервер дергает метод ReceiveMessage у всех подключенных клиентов с параметрами user, message
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}