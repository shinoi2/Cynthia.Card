using System.Collections.Generic;

namespace Cynthia.Card.Server
{
    public interface IMessagesService
    {
        void AddMessage(ChatMessage data);
        void AddMessage(IEnumerable<ChatMessage> data);
        int Count { get; }
        IEnumerable<ChatMessage> GetMessage(int count);
        IEnumerable<ChatMessage> GetLastMessage(int count = 60);
    }
}