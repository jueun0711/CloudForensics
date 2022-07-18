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

			/*Console.WriteLine("------------Meeting Information---------------");
			Console.WriteLine($"Index / Total Meeting : {Index} / {TotalRecords}");
			Console.WriteLine($"Topic: {Topic}");
			Console.WriteLine($"Created On : {CreatedOn}");
			Console.WriteLine($"Records Ids: {Id}");
			Console.WriteLine($"Record Start Time: {StartTime}");
			Console.WriteLine($"Agenda : {Agenda}");
			Console.WriteLine($"HostId : {HostId}");
			Console.WriteLine($"StartUrl : {StartUrl}");
			Console.WriteLine($"Personal Meeting Id : {PersonalMeetingId}");
			Console.WriteLine($"Timezone : {Timezone}");
			Console.WriteLine($"Type : {Type}");
			Console.WriteLine($"Uuid : {Uuid}");
			Console.WriteLine($"Duration : {Duration}");
			Console.WriteLine();*/
		}
	}
}
