using MyChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyChatApp.Hubs
{
    public class ChatHub : Hub
    { public async Task SendMessage(Message meassage )= >
            await Clients.All.SendAsync("receiveMessage",message);
             
    }
}