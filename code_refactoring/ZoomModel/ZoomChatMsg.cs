using System;

namespace CloudForensics.ZoomModel
{
    public class ZoomChatMsg
    {

	public string Id { get; set; }

	public string Message { get; set; }

	public DateTime SentOn { get; set; }

	public long Timestamp { get; set; }

        public int Index { get; set; }

        public int TotalRecords { get; set; }

        public override string ToString()
        {
            return "-----------------Chat Message--------------------\n"
                + $"Message # : {Index} / {TotalRecords}\n"
                + $"ID : {Id}\n"
                + $"Message: {Message}\n"
                + $"SentOn: {SentOn}\n"
                + $"Timestamp: {Timestamp}\n\n";
        }
    }
}
