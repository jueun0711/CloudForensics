using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomMeeting
    {
		public string Agenda { get; set; }

		public DateTime CreatedOn { get; set; }

		public int Duration { get; set; }

		public string HostId { get; set; }

		public long Id { get; set; }

		public int Index { get; set; }

		public int TotalRecords { get; set; }

		public string StartUrl { get; set; }

		public string PersonalMeetingId { get; set; }

		public DateTime StartTime { get; set; }

		public string Timezone { get; set; }

		public string Topic { get; set; }

		public MeetingType Type { get; set; }

		public string Uuid { get; set; }

		public override string ToString()
		{
			return "------------Meeting Information---------------\n"
				+ $"Index / Total Meeting : {Index} / {TotalRecords}\n"
				+ $"Topic: {Topic}\n"
				+ $"Created On : {CreatedOn}\n"
				+ $"Records Ids: {Id}\n"
				+ $"Record Start Time: {StartTime}\n"
				//+ $"Agenda : {Agenda}\n"
				+ $"HostId : {HostId}\n"
				//+ $"StartUrl : {StartUrl}\n"
				//+ $"Personal Meeting Id : {PersonalMeetingId}\n"
				+ $"Timezone : {Timezone}\n"
				+ $"Type : {Type}\n"
				+ $"Uuid : {Uuid}\n"
				+ $"Duration : {Duration}\n\n";
		}
	}
}
