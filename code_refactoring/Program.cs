/*.NET 4.8 Zoomnet 0.45.0 & pro account */
using System;


namespace CloudForensics
{
    class Program
    {
        //fixed
        private const string clientId = "(Client ID)";
        private const string clientSecret = "(Client Secret)";
        private const string id = "(ID)";

        //variable
        private const string accessToken = "(Access ToKen)";
        private const string refreshToken = "(Refresh Token)";

        private const string downloadPath = "(Recording File Download Path)";

        static void Main(string[] args)
        {
            var zoom = new ZoomExtractor(clientId, clientSecret, refreshToken, accessToken);

            var user = zoom.GetUser(from: id).Result;
            var meetings = zoom.GetMeetings(from: id).Result;
            var pastMeetings = zoom.GetPastMeetings(from: id).Result;
            var recordings = zoom.GetRecordings(from: id).Result;
            var chatList = zoom.GetChatList(from: id).Result;

            //=================test======================
            Console.WriteLine($"{user}");
            for (int i = 0; i < meetings.Count; i++) { Console.WriteLine($"{meetings[i]}"); }
            for (int i = 0; i < pastMeetings.Count; i++) { Console.WriteLine($"{pastMeetings[i]}"); }

            for (int i = 0; i < recordings.Count; i++)
            {
                Console.WriteLine($"{recordings[i]}");
                for (int j = 0; j < recordings[i].RecordingFiles.Length; j++)
                {
                    Console.WriteLine($"{recordings[i].RecordingFiles[j]}");

                    bool success = zoom.DownloadRecordings(recordings[i], downloadPath).Result;

                    if(success) Console.WriteLine($"file download : success\n");
                    else Console.WriteLine($"file download : fail\n");
                }
            }
            for (int i = 0; i < chatList.Count; i++)
            {
                Console.WriteLine($"{chatList[i]}");
                for (int j = 0; j < chatList[i].ChatMems.Count; j++)
                {
                    Console.WriteLine($"{chatList[i].ChatMems[j]}");
                }
                for (int j = 0; j < chatList[i].ChatMsgs.Count; j++)
                {
                    Console.WriteLine($"{chatList[i].ChatMsgs[j]}");
                }
            }

            Console.WriteLine("====== End ======");
            Console.ReadKey();
        }
    }
}
