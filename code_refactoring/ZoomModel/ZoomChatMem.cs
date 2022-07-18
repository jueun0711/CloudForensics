using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomChatMem
    {
		public string Id { get; set; }

		public string Email { get; set; }

		public string Name { get; set; }

		public ChatChannelRole Role { get; set; }

        public int Index { get; set; }

        public int TotalRecords { get; set; }

        public override string ToString()
        {
            return "--------Chat Channels Member Information-------\n"
                + $"Member # : {Index} / {TotalRecords}\n"
                + $"Name : {Name}\n"
                + $"Email : {Email}\n"
                + $"Id : {Id}\n"
                + $"Role : {Role}\n\n";

            /*Console.WriteLine($"--------Print Chat Channels Member Information-------");
            Console.WriteLine($"Member Index / Total Member : {Index} / {TotalRecords}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine();*/
        }
    }
}
