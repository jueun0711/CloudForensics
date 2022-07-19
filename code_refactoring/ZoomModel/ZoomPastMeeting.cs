using System;
using ZoomNet.Models;
namespace CloudForensics.ZoomModel
{
    public class ZoomPastMeeting        //https://github.com/Jericho/ZoomNet/blob/develop/Source/ZoomNet/Models/Meeting.cs
    {
        public string Uuid { get; set; }

        public long Id { get; set; }

        public string HostId { get; set; }

        public string Topic { get; set; }

        public MeetingType Type { get; set; }

        public MeetingStatus? Status { get; set; }

        public string Agenda { get; set; }

        public DateTime CreatedOn { get; set; }

        public string StartUrl { get; set; }

        public string JoinUrl { get; set; }

        public string Password { get; set; }

        public string H323Password { get; set; }

        public string PstnPassword { get; set; }

        public MeetingSettings Settings { get; set; }

        public int Index { get; set; }

        public int TotalRecords { get; set; }

        public override string ToString()
        {
            return "---------Past Meeting information---------\n"
                + $"Index / Total Meeting : {Index} / {TotalRecords}\n"
                + $"Uuid : {Uuid}\n"
                + $"User Id: {Id}\n"
                + $"Host key : {HostId}\n"
                + $"Topic : {Topic}\n"
                + $"Type : {Type}\n";
                //+ $"Status : {Status}\n"
                //+ $"Agenda : {Agenda}\n"
                //+ $"Created On : {CreatedOn}\n"
                //+ $"StartUrl : {StartUrl}\n"
                //+ $"JoinUrl : {JoinUrl}\n"
                //+ $"Password : {Password}\n"
                //+ $"H323Password : {H323Password}\n"
                //+ $"PstnPassword : {PstnPassword}\n"
                //+ $"Settings : {Settings}\n\n";
    }
    }
}