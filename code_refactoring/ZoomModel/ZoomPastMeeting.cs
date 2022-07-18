using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoomNet;
using ZoomNet.Models;
namespace CloudForensics.ZoomModel
{
    public class ZoomPastMeeting
    {
        public string Uuid { get; set; }

        public long Id { get; set; }

        public string HostId { get; set; }

        public string Topic { get; set; }

        public MeetingType Type { get; set; }

        public DateTime CreatedOn { get; set; }

        public override string ToString()
        {
            return "---------Past Meeting information---------\n"
           + $"User Id: {Id}\n"
           + $"Host key : {HostId}\n"
           + $"Topic : {Topic}\n"
           + $"Created On : {CreatedOn}\n"
           + $"Uuid : {Uuid}\n"
           + $"Type : {Type}\n\n";
        }
    }
}