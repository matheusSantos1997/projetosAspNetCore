using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace SignalRChatServerTest.HubSignalR
{
    public class Chat : Hub
    {
        public static List<Message>? Messages;

        public Chat()
        {
            if(Messages == null)
                Messages = new List<Message>();
        }

        public Task NewMessage(string userName, string text)
        {
            var messageSend = Clients.All.SendAsync("newMessage", userName, text);

            Messages?.Add(new Message()
            {
                Text = text,
                UserName = userName,
            });

            return messageSend;
        }

        public void NewUser(string userName, string connectionId)
        {
            Clients.Client(connectionId).SendAsync("previousMessages", Messages);
            Clients.All.SendAsync("newUser", userName);
        }
    }
}
