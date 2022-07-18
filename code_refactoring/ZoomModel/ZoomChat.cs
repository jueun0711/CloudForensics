using System;
using System.Collections.Generic;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomChat
    {
	public string Id { get; set; }

	public string JId { get; set; }

	public string Name { get; set; }

        public int Index { get; set; }

        public int TotalRecords { get; set; }

        public ChatChannelType Type { get; set; }

        public List<ZoomChatMem> ChatMems { get; set; }

        public List<ZoomChatMsg> ChatMsgs { get; set; }

        public override string ToString()
        {
            return "-------------Chat Channel Information------------\n"
                + $"Channel # : {Index} / {TotalRecords}\n"
                + $"Id : {Id}\n"
                + $"JId : {JId}\n"
                + $"Name : {Name}\n"
                + $"Type : {Type}\n"
                + $"Chat Member # : {ChatMems.Count}\n"
                + $"Chat Message # : {ChatMsgs.Count}\n\n";
        }
    }
}
