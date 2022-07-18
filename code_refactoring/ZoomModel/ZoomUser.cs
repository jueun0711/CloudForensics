using System;

namespace CloudForensics.ZoomModel
{
    public class ZoomUser
    {
        public string Id { get; set; } // get user id
        
        public string Name { get; set; } // get first, last name
        
        public string HostKey { get; set; } // get host key
        
        public string CmsUserId { get; set; } // get cms user id
        
        public string Company { get; set; } //get company 
        
        public DateTime CreatedOn { get; set; } //get time created on
        
        public string Department { get; set; } // get department information
        
        public string Email { get; set; } // get email

        public override string ToString()
        {
            return "---------User's information---------\n"
                + $"User Id: {Id}\n"
                + $"Host key : {HostKey}\n"
                + $"Cms UserId: {CmsUserId}\n"
                + $"Company : {Company}\n"
                + $"Created On : {CreatedOn}\n"
                + $"Department: {Department}\n"
                + $"Email : {Email}\n"
                + $"User Name : {Name}\n\n";
            /*Console.WriteLine("---------Print User's information---------");
            Console.WriteLine($"User Id: {Id}");
            Console.WriteLine($"Host key : {HostKey}");
            Console.WriteLine($"Cms UserId: {CmsUserId}");
            Console.WriteLine($"Company : {Company}");
            Console.WriteLine($"Created On : {CreatedOn}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"User Name : {Name}");
            Console.WriteLine();*/
        }
    }
}