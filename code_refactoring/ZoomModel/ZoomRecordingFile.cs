using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomRecordingFile
    {

		public string Id { get; set; }

		public string MeetingId { get; set; }

		public DateTime StartTime { get; set; }

		public DateTime? EndTime { get; set; }

		public RecordingFileType FileType { get; set; }

		public long Size { get; set; }

		public string PlayUrl { get; set; }

		public string DownloadUrl { get; set; }

		public string Status { get; set; }

		public DateTime? DeleteTime { get; set; }

		public RecordingContentType ContentType { get; set; }

		public int Index { get; set; }

		public int TotalRecords { get; set; }

        public override string ToString()
        {
			return "---------Recording File Information---------\n"
				+ $"Member # : {Index} / {TotalRecords}\n"
				+ $"Id : {Id}\n"
				+ $"MeetingId : {MeetingId}\n"
				+ $"StartTime : {StartTime}\n"
				+ $"EndTime : {EndTime}\n"
				+ $"FileType : {FileType}\n"
				+ $"Size : {Size}\n"
				+ $"PlayUrl : {PlayUrl}\n"
				+ $"DownloadUrl : {DownloadUrl}\n"
				+ $"Status : {Status}\n"
				+ $"DeleteTime : {DeleteTime}\n"
				+ $"ContentType : {ContentType}\n\n";
		}
    }
}
