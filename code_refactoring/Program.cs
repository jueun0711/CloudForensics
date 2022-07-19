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
        private const string accessToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiJiMjVkYzQ3OS1iYjAxLTQxOGMtYjUzMC02NGUzMzZmZTA3YmUifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJpTFdBSHptYnVXX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MCwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MTk0OTI1LCJleHAiOjE2NTgxOTg1MjUsImlhdCI6MTY1ODE5NDkyNSwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6ImM4Y2M5MWJjLTcwOTYtNDBmNC1hZGRmLWNkZjZkZjk2YzA5YiJ9.1QZ2JbqmOFkM6sa2-9pb7JZp0FOES5p_BlPhDPTm9E06IffYJ6UGoJZQhIgkHwuVVTCs2CPXNZ57r64uOkOT2w";
        private const string refreshToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiI5ZDZlMWVlNi0xZmI2LTQ5ZjctOWFmYi0xNjRjZWM2YWVlYmIifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJpTFdBSHptYnVXX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MSwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MTk0OTI1LCJleHAiOjIxMzEyMzQ5MjUsImlhdCI6MTY1ODE5NDkyNSwiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6IjQzYTk1NmZjLThlZWMtNDg2MS1hMGJhLTMxZTgxOTQyNjFkYyJ9.x3iICQypd1A6hHS2k_8mmhXrtqJxoP2ErriJNX_7jwzxuEkdi2el-t5RRn95DOSoEcxmhrH9cfkX3tzWF8aisw";

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
            for (int i = 0; i < recordings.Count; i++) { Console.WriteLine($"{recordings[i]}"); }
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