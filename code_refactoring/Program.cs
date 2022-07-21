/*.NET 4.8 Zoomnet 0.45.0 & pro account */
using System;


namespace CloudForensics
{
    class Program
    {
        //fixed
        private const string clientId = "2Oo4AoqtRiqMu6bJ9GIkQw";
        private const string clientSecret = "2IPDJaQFclpAA46hz8ET2mJV2emtE9hE";
        private const string id = "forensics_marketing@hancom.com";

        //variable
        private const string accessToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiJiMTNiYmQ4Mi05YmUyLTQ2NzktOWJkYy0zYWRlZWZjMDhiYTIifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJ5bExxeTV1VEZlX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MCwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MzU5NzU1LCJleHAiOjE2NTgzNjMzNTUsImlhdCI6MTY1ODM1OTc1NSwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6ImM1MTIyMzE3LWQ2ZGUtNDZjMS1iMDY3LTFjYzAxOTVkMmQ4MyJ9.wFFgL6Q0UDEBdggQJseSoR4dWQSDuCvxS6HPFPuhnhFgT8zIMUhKBWtrbhniQQOe6L5M6ruDGxMtfu3XsMrkQg";
        private const string refreshToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiI3YzMyNmYyOC01NzExLTQxMjQtYTgxOS00OTRmNmZkNjI0YTEifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJ5bExxeTV1VEZlX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MSwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MzU5NzU1LCJleHAiOjIxMzEzOTk3NTUsImlhdCI6MTY1ODM1OTc1NSwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6Ijk2NDFhZTYyLTZjYmEtNGIzZS1hZjZiLWVjMjAwYWJhYmRkNiJ9.jjHIKsE47Nq44N9hf-Iv4US4nvUVdQEpcF-0Czu63F0Evaug7Lr9Y2dD-QroC3DALuQ7iZUL7etHkrQEqedwsA";

        private const string downloadPath = "C:/Users/USER/Downloads";

        static void Main(string[] args)
        {
            var zoom = new ZoomExtractor(clientId, clientSecret, refreshToken, accessToken);

            var user = zoom.GetUser(from: id).Result;
            var meetings = zoom.GetMeetings(from: id).Result;
            var pastMeetings = zoom.GetPastMeetings(from: id).Result;
            var recordings = zoom.GetRecordings(from: id).Result;
            var chatList = zoom.GetChatList(from: id).Result;

            //=================test======================
            //Console.WriteLine($"{user}");
            //for (int i = 0; i < meetings.Count; i++) { Console.WriteLine($"{meetings[i]}"); }
            //for (int i = 0; i < pastMeetings.Count; i++) { Console.WriteLine($"{pastMeetings[i]}"); }
            //for (int i = 0; i < recordings.Count; i++) { Console.WriteLine($"{recordings[i]}"); }
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
            /*for (int i = 0; i < chatList.Count; i++)
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
            }*/

            Console.WriteLine("====== End ======");
            Console.ReadKey();
        }
    }
}