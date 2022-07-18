using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZoomNet;
using ZoomNet.Models;
using CloudForensics.ZoomModel;

namespace CloudForensics
{
    public class ZoomExtractor
    {

        private OAuthConnectionInfo connectionInfo;

        public ZoomExtractor(string clientId, string clientSecret, string refreshToken, string accessToken)
        {
            this.connectionInfo = new OAuthConnectionInfo(clientId, clientSecret, refreshToken, accessToken,
                (newRefreshToken, newAccessToken) =>
                {
                    newRefreshToken = refreshToken;
                    newAccessToken = accessToken;
                });
        }

        public async Task<ZoomUser> GetUser(string from)
        {
            var zu = new ZoomUser();
            using (var client = new ZoomClient(connectionInfo))
            {
                var user = await client.Users.GetAsync(from);
                zu.Id = user.Id;
                zu.HostKey = user.HostKey;
                zu.CmsUserId = user.CmsUserId;
                zu.Company = user.Company;
                zu.CreatedOn = user.CreatedOn;
                zu.Department = user.Department;
                zu.Email = user.Email;
                zu.Name = user.FirstName + " " + user.LastName;
            }

            return zu;
        }

        public async Task<List<ZoomMeeting>> GetMeetings(string from)
        {
            var zmList = new List<ZoomMeeting>();
            using (var client = new ZoomClient(connectionInfo))
            {
                var meeting = await client.Meetings.GetAllAsync(from, MeetingListType.Scheduled, 30, null, default);
                for (int i = 0; i < meeting.Records.Length; i++)
                {
                    var zm = new ZoomMeeting();

                    zm.Index = i + 1;
                    zm.TotalRecords = meeting.Records.Length;
                    zm.Agenda = meeting.Records[i].Agenda;
                    zm.CreatedOn = meeting.Records[i].CreatedOn;
                    zm.Duration = meeting.Records[i].Duration;
                    zm.HostId = meeting.Records[i].HostId;
                    zm.Id = meeting.Records[i].Id;
                    zm.PersonalMeetingId = meeting.Records[i].PersonalMeetingId;
                    zm.StartTime = meeting.Records[i].StartTime;
                    zm.StartUrl = meeting.Records[i].StartUrl;
                    zm.Timezone = meeting.Records[i].Timezone;
                    zm.Topic = meeting.Records[i].Topic;
                    zm.Type = meeting.Records[i].Type;
                    zm.Uuid = meeting.Records[i].Uuid;

                    zmList.Add(zm);
                }
            }

            return zmList;
        }

        public async Task<List<ZoomPastMeeting>> GetPastMeetings(string from)
        {
            var zpList = new List<ZoomPastMeeting>();
            using (var client = new ZoomClient(connectionInfo))
            {
                var getUuid = await client.CloudRecordings.GetRecordingsForUserAsync(from, false, DateTime.MinValue, DateTime.MaxValue, 30, null, default);
                for (int i = 0; i < getUuid.Records.Length; i++)
                {
                    var pastMeeting = await client.PastMeetings.GetAsync(getUuid.Records[i].Uuid); // input uuid
                    var zp = new ZoomPastMeeting();
                    zp.Topic = pastMeeting.Topic;
                    zp.Id = pastMeeting.Id;
                    zp.HostId = pastMeeting.HostId;
                    zp.Uuid = pastMeeting.Uuid;
                    zp.Type = pastMeeting.Type;
                    zp.CreatedOn = pastMeeting.CreatedOn;
                    zpList.Add(zp);
                }
            }

            return zpList;
        }

        public async Task<List<ZoomRecording>> GetRecordings(string from)
        {
            var zrList = new List<ZoomRecording>();
            using (var client = new ZoomClient(connectionInfo))
            {
                var recording = await client.CloudRecordings.GetRecordingsForUserAsync(from, false, DateTime.MinValue, DateTime.MaxValue, 30, null, default);
                for (int i = 0; i < recording.Records.Length; i++)
                {
                    var zr = new ZoomRecording();
                    zr.Index = i + 1;
                    zr.TotalRecords = recording.Records.Length;
                    zr.Topic = recording.Records[i].Topic;
                    zr.Id = recording.Records[i].Id;
                    zr.AccountId = recording.Records[i].AccountId;
                    zr.Uuid = recording.Records[i].Uuid;
                    zr.HostId = recording.Records[i].HostId;
                    zr.StartTime = recording.Records[i].StartTime;
                    zr.Duration = recording.Records[i].Duration;
                    zr.ShareUrl = recording.Records[i].ShareUrl;
                    zr.TotalSize = recording.Records[i].TotalSize;
                    zr.FilesCount = recording.Records[i].FilesCount;
                    zrList.Add(zr);
                }
            }

            return zrList;
        }

        public async Task<List<ZoomChat>> GetChatList(string from)
        {
            var zcList = new List<ZoomChat>();

            using (var client = new ZoomClient(connectionInfo))
            {
                var chat = await client.Chat.GetAccountChannelsForUserAsync(from, 30, null, default);

                for (int i = 0; i < chat.TotalRecords; i++)
                {
                    var zc = new ZoomChat();

                    zc.Id = chat.Records[i].Id;
                    zc.JId = chat.Records[i].JId;
                    zc.Name = chat.Records[i].Name;
                    zc.Type = chat.Records[i].Type;
                    zc.Index = i + 1;
                    zc.TotalRecords = chat.Records.Length;
                    zc.ChatMems = getChatMems(from, chat.Records[i].Id).Result;
                    zc.ChatMsgs = getChatMsgs(from, chat.Records[i].Id).Result;

                    zcList.Add(zc);
                }
            }

            return zcList;
        }

        private async Task<List<ZoomChatMem>> getChatMems(string from, string channelId)
        {
            var zmList = new List<ZoomChatMem>();

            using (var client = new ZoomClient(connectionInfo))
            {
                var chatAcChanMem = await client.Chat.GetAccountChannelMembersAsync(from, channelId, 30, null, default);

                for (int j = 0; j < chatAcChanMem.TotalRecords; j++)
                {
                    var zm = new ZoomChatMem();

                    zm.Index = j + 1;
                    zm.TotalRecords = chatAcChanMem.Records.Length;
                    zm.Id = chatAcChanMem.Records[j].Id;
                    zm.Email = chatAcChanMem.Records[j].Email;
                    zm.Name = chatAcChanMem.Records[j].FirstName + " " + chatAcChanMem.Records[j].LastName;
                    zm.Role = chatAcChanMem.Records[j].Role;

                    zmList.Add(zm);
                }
            }
            return zmList;
        }

        private async Task<List<ZoomChatMsg>> getChatMsgs(string from, string channelId)
        {
            var zmList = new List<ZoomChatMsg>();

            using (var client = new ZoomClient(connectionInfo))
            {
                var chatMsg = await client.Chat.GetMessagesToChannelAsync(from, channelId, 30, null, default);

                for (int i = 0; i < chatMsg.TotalRecords; i++)
                {
                    var zm = new ZoomChatMsg();

                    zm.Index = i + 1;
                    zm.TotalRecords = chatMsg.Records.Length;
                    zm.Id = chatMsg.Records[i].Id;
                    zm.Message = chatMsg.Records[i].Message;
                    zm.SentOn = chatMsg.Records[i].SentOn;
                    zm.Timestamp = chatMsg.Records[i].Timestamp;

                    zmList.Add(zm);
                }
            }

            return zmList;
        }
    }
}
