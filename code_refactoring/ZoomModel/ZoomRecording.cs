using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomRecording          //https://github.com/Jericho/ZoomNet/blob/develop/Source/ZoomNet/Models/Recording.cs
    {
        public string Uuid { get; set; }

        public long Id { get; set; }

        public string AccountId { get; set; }

        public string HostId { get; set; }

        public string Topic { get; set; }

        public DateTime StartTime { get; set; }

        public long Duration { get; set; }

        public long TotalSize { get; set; }

        public long FilesCount { get; set; }

        public RecordingFile[] RecordingFiles { get; set; }

        public string ShareUrl { get; set; }

        public string Password { get; set; }

        public RecordingFile[] ParticipantAudioFiles { get; set; }

        public int Index { get; set; }

        public int TotalRecords { get; set; }

        public override string ToString()
        {
            return "---------Recording information---------\n"
                + $"Index / Total Recording : {Index} / {TotalRecords}\n"
                + $"Topic : {Topic}\n"
                + $"User Id: {Id}\n"
                + $"Host Id : {HostId}\n"
                + $"Account Id : {AccountId}\n"
                + $"Uuid : {Uuid}\n"
                + $"Start Time : {StartTime}\n"
                + $"Duration : {Duration}\n"
                + $"FIlesCount : {FilesCount}\n"
                + $"RecordingFiles: {RecordingFiles}\n"
                + $"Share Url: {ShareUrl}\n"
                + $"Total Size : {TotalSize}\n\n";
                //+ $"Password: {Password}\n"
                //+ $"ParticipantAudioFiles: {ParticipantAudioFiles}\n"
        }
    }
}