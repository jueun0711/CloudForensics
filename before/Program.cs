/*user managed app*/

using System;
using System.Threading.Tasks;
using ZoomNet;
using ZoomNet.Utilities;
using ZoomNet.Resources;


namespace zoomCloud
{
    class ZoomCloud
    {
        private const string clientId = "LNN1PZDSLWps6uTM5__Q";
        private const string clientSecret = "6yJTbm2G42o2vLZRjgZyGh2ufE9Wgti3";
        private const string id = "onesimkim2018@gmail.com";
        private const string ZOOM_V2_BASE_URI = "https://api.zoom.us/profile";
        private const long meetingId = 3277312251;
        private const long accountId = 7025008868;

        private const string refreshToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiJhZWQ4ZmZkZS1lM2M3LTRkZjEtOGI5ZC00NThhODRmNzRjOTUifQ.eyJ2ZXIiOjcsImF1aWQiOiJkNDdiODQ5Y2U0NDc5ZGRhZTkwZTJkMjQ5NDE0MTM1NyIsImNvZGUiOiJVemZhTFFReHJXX01vYkI2ZTEzVE42TzRYNV82dUVpSGciLCJpc3MiOiJ6bTpjaWQ6TE5OMVBaRFNMV3BzNnVUTTVfX1EiLCJnbm8iOjAsInR5cGUiOjEsInRpZCI6MCwiYXVkIjoiaHR0cHM6Ly9vYXV0aC56b29tLnVzIiwidWlkIjoiTW9iQjZlMTNUTjZPNFg1XzZ1RWlIZyIsIm5iZiI6MTY1Nzc3MzY2MiwiZXhwIjoyMTMwODEzNjYyLCJpYXQiOjE2NTc3NzM2NjIsImFpZCI6Im1vNnhpUnR2Uks2YURMenFJdmtjakEiLCJqdGkiOiI2YmRiYzAwMy0xZTE2LTRhZTYtYTQyZC00OThhNjM3M2FiZDQifQ.lthl2yE2fBYZX2iOZGLpK1lflaJvSD4PCtzDn-fSkEYTgxWl-xwHwjF5H3xgQjnLzH_sK4OXjUwcbJYa_ar5xA";
        private const string accessToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiI3MTdjNzAzZS04Zjk0LTQ5M2QtOGU0ZS0xMzMzY2RiNWIxNzEifQ.eyJ2ZXIiOjcsImF1aWQiOiJkNDdiODQ5Y2U0NDc5ZGRhZTkwZTJkMjQ5NDE0MTM1NyIsImNvZGUiOiJVemZhTFFReHJXX01vYkI2ZTEzVE42TzRYNV82dUVpSGciLCJpc3MiOiJ6bTpjaWQ6TE5OMVBaRFNMV3BzNnVUTTVfX1EiLCJnbm8iOjAsInR5cGUiOjAsInRpZCI6MCwiYXVkIjoiaHR0cHM6Ly9vYXV0aC56b29tLnVzIiwidWlkIjoiTW9iQjZlMTNUTjZPNFg1XzZ1RWlIZyIsIm5iZiI6MTY1Nzc3MzY2MiwiZXhwIjoxNjU3Nzc3MjYyLCJpYXQiOjE2NTc3NzM2NjIsImFpZCI6Im1vNnhpUnR2Uks2YURMenFJdmtjakEiLCJqdGkiOiI4M2VlZTczMC1lODgwLTQ4YmMtYWMxMi02ZTk1MTg1ZjU3NTIifQ.w2mZ4cC-PBje6LquIuMC7Dk_1rcKEHS-UKbIkJqGPMva3dgQJxNzG0-nQLqhRGFFGKQb9me87tKTIq9AdhDysg";

        public async void GetInfo()
        {
            //var connectionInfo = new OAuthConnectionInfo(clientId, clientSecret, accountId, null);
            var connectionInfo = new OAuthConnectionInfo(clientId, clientSecret, refreshToken, accessToken,
                (newRefreshToken, newAccessToken) =>
                {
                    newRefreshToken = refreshToken;
                    newAccessToken = accessToken;
                }) ;

            using (var client = new ZoomClient(connectionInfo))
            {
                var chat = await client.Chat.GetAccountChannelsForUserAsync(id, 30, null, default);

                Console.WriteLine("--------------------------CHAT INFORMATION--------------------------");
                Console.WriteLine($"chat total records : {chat.TotalRecords}");

                for (int i = 0; i < chat.TotalRecords; i++)
                {
                    //Meeting meetingTmp = await client.PastMeetings.GetAsync(recording.Records[i].Uuid);
                    //pastMeeting.Add(meetingTmp);

                    //var chatAcChan = await client.Chat.GetAccountChannelAsync(id, chat.Records[i].Id, default);   //same to chat
                    var chatAcChanMem = await client.Chat.GetAccountChannelMembersAsync(id, chat.Records[i].Id, 30, null, default);
                    var chatChan = await client.Chat.GetChannelAsync(chat.Records[i].Id, default);
                    var chatMsg = await client.Chat.GetMessagesToChannelAsync(id, chat.Records[i].Id, 30, null, default);

                    Console.WriteLine($"chat Id : {chat.Records[i].Id}");
                    Console.WriteLine($"chat JId : {chat.Records[i].JId}");
                    Console.WriteLine($"chat Name : {chat.Records[i].Name}");
                    Console.WriteLine($"chat Settings : {chat.Records[i].Settings}");
                    Console.WriteLine($"chat Type : {chat.Records[i].Type}");
                    Console.WriteLine();
                    Console.WriteLine($"chat account channels member total records : {chatAcChanMem.TotalRecords}");

                    for (int j = 0; j < chatAcChanMem.TotalRecords; j++)
                    {
                        Console.WriteLine($"--------chat account channels member-------");
                        Console.WriteLine($"chat account channels member Email : {chatAcChanMem.Records[j].Email}");
                        Console.WriteLine($"chat account channels member FirstName : {chatAcChanMem.Records[j].FirstName}");
                        Console.WriteLine($"chat account channels member LastName : {chatAcChanMem.Records[j].LastName}");
                        Console.WriteLine($"chat account channels member Id : {chatAcChanMem.Records[j].Id}");
                        Console.WriteLine($"chat account channels member Role : {chatAcChanMem.Records[j].Role}");
                        Console.WriteLine();
                    }

                    Console.WriteLine($"chat msg : {chatMsg.TotalRecords}");
                    for (int j = 0; j < chatMsg.TotalRecords; j++)
                    {
                        Console.WriteLine($"chat msg ID : {chatMsg.Records[j].Id}");
                        Console.WriteLine($"chat msg Message: {chatMsg.Records[j].Message}");
                        Console.WriteLine($"chat msg SentOn: {chatMsg.Records[j].SentOn}");
                        Console.WriteLine($"chat msg Timestamp: {chatMsg.Records[j].Timestamp}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var zoom = new ZoomCloud();
            zoom.GetInfo();
            //var result = zoom.GetInfo();

            Console.ReadKey();
        }
    }
}