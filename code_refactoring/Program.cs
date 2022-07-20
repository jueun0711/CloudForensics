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
        private const string accessToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiJiZDdkYzUwNi01NmJiLTRkNGEtYjdiZS1kYmJjZWY3M2E2NTEifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJZMG5sSDVQMU5QX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MCwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4Mjc4MDk2LCJleHAiOjE2NTgyODE2OTYsImlhdCI6MTY1ODI3ODA5NiwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6IjgyZmE0ZjIzLTAxM2UtNGRjMC05MGZlLTNjOGEyNGVjMDE2ZiJ9._PbprLwt2B5ePxRWGt3ratAkTxi0XiCjY3JaQCh-xeG4658CdQY8mzGhS4CKU2sFskVviWlO6YbP4C4ocO6Bog";
        private const string refreshToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiI4ZGE2YjYyMC00M2UwLTQwODItOTA1Ny1jMDE5N2Q0MTZiMDIifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJZMG5sSDVQMU5QX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MSwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4Mjc4MDk2LCJleHAiOjIxMzEzMTgwOTYsImlhdCI6MTY1ODI3ODA5NiwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6IjhmNjUzYTQwLTNhMzctNDVhMi1iYjE0LWJlYTRjZjMwYTI0NiJ9.arSp6DClaeDFbs_KnDRd32xLjBbtHFb0wKkp7Kq7CGlRVwgOVsCkz0mYRd4kZk6lhW8wlkZGqM1YiyOPbIeeIA";

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
                    System.Diagnostics.Process.Start(recordings[i].RecordingFiles[j].DownloadUrl);
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

            Console.ReadKey();
        }
    }
}