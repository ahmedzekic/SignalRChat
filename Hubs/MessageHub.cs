using Microsoft.AspNetCore.SignalR;
using SignalRchat.Models;
using System.Threading.Tasks;  
  
namespace SignalRchat.Hubs  
{  
    public class MessageHub : Hub  
    {  
        public async Task NewMessage(Message msg)  
        {  
            await Clients.All.SendAsync("MessageReceived", msg);  
        }  
    }  
} 