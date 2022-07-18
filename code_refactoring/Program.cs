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
        private const string accessToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiIwY2RiOWYzYS1mNjE2LTRjOWYtOGNlMC02MzdmNDA0NDA3N2QifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJaMThkZzV2akFrX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MCwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MTA3ODczLCJleHAiOjE2NTgxMTE0NzMsImlhdCI6MTY1ODEwNzg3MywiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6IjgxNmE5ZjU3LWE1YzctNDM0MC1hYTk1LWVmODQzZTUxY2NlMSJ9.FvDs47lamwbUbLdx2ZIqzHaM86k69IQumd45spUzAuFT9iTRJ7p3r_R2dDwy3ARX4dvzruzViMfU71y5MZyJEw";
        private const string refreshToken = "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiI1ZDYxOTIwNC1jZTVmLTRjNDctYjk4Ni1lMDY4ODEwZmU3ZWMifQ.eyJ2ZXIiOjcsImF1aWQiOiI1Yzg0NjljMmNmNTRhMDNjZTc4NTQxOGNhOGVmYTFjNCIsImNvZGUiOiJaMThkZzV2akFrX2tWNXZjZ1RFUmdpNlFzdUtobkhzX3ciLCJpc3MiOiJ6bTpjaWQ6Mk9vNEFvcXRSaXFNdTZiSjlHSWtRdyIsImdubyI6MCwidHlwZSI6MSwidGlkIjowLCJhdWQiOiJodHRwczovL29hdXRoLnpvb20udXMiLCJ1aWQiOiJrVjV2Y2dURVJnaTZRc3VLaG5Ic193IiwibmJmIjoxNjU4MTA3ODczLCJleHAiOjIxMzExNDc4NzMsImlhdCI6MTY1ODEwNzg3MywiYWlkIjoiWE84azhod01RZWFGYU5IX29XMjVVQSIsImp0aSI6IjQ4ZTgwZWYzLWJjZTQtNGE1Mi1hODUwLWU1M2Q0ODAyNDU1NCJ9.DfzwFTYXk6vVuXZiVAzU3BDRYyBNAx2ttz6pA-pi3qbDchdOqOaWqx9KNqdGGZKGhuiAG72G_N_6rlttnqTyow";

        static void Main(string[] args)
        {
            var zoom = new ZoomExtractor(clientId, clientSecret, refreshToken, accessToken);

            var user = zoom.GetUser(from: id).Result;
            var meetings = zoom.GetMeetings(from: id).Result;
            var pastMeetings = zoom.GetPastMeetings(from: id).Result;
            var recordings = zoom.GetRecordings(from: id).Result;
            var chatList = zoom.GetChatList(from: id).Result;

            //Console.WriteLine($"{user}");
            for (int i = 0; i < meetings.Count; i++) { Console.WriteLine($"{meetings[i]}"); }
            /*for (int i = 0; i < pastMeetings.Count; i++) { Console.WriteLine($"{pastMeetings[i]}"); }
            for (int i = 0; i < recordings.Count; i++) { Console.WriteLine($"{recordings[i]}"); }
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
            }*/

            Console.ReadKey();
        }
    }
}