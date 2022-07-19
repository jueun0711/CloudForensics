using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomChatMem                //https://github.com/Jericho/ZoomNet/blob/develop/Source/ZoomNet/Models/ChatChannelMember.cs
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
        }
    }
}
