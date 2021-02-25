using System;

namespace Class_Author
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Message message = new Message("John");
                message.sendTime = DateTime.Now;
                message.content = "They gooks in the trees !";
                message.isReply = true;
                message.WriteMessageToConsole();

                Author Author = new Author();
                Author.ip = "192.67.234.56";
                Author.isOnline = true;
                Author.Authorinfo();
            }
        }


        class Message
        {
            public string username;
            public DateTime sendTime;
            public string content;
            public bool isRead = false;
            public bool isReply;
            public Message(string username)
            {
                this.username = username;
            }
            public void WriteMessageToConsole()
            {
                Console.WriteLine($"@{username}: {content} | {sendTime} | is read: {isRead}| is reply: {isReply}");
            }
        }
            class Author
        {
            public string ip;
            public bool isOnline;
            public void Authorinfo()
            {
                Console.WriteLine($"isOnline: {isOnline} | IP: {ip}");
            }

        }
    }
}

