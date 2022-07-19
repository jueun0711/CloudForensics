using System;
using ZoomNet.Models;

namespace CloudForensics.ZoomModel
{
    public class ZoomUser       //https://github.com/Jericho/ZoomNet/tree/develop/Source/ZoomNet/Models/User.cs
	{
		public string Id { get; set; }

		public DateTime CreatedOn { get; set; }

		public string Department { get; set; }

		public string Email { get; set; }

		public string Name { get; set; }

		public string LastLoginClientVersion { get; set; }

		public DateTime LastLogin { get; set; }

		public long PersonalMeetingId { get; set; }

		public string RoleName { get; set; }

		public string Timezone { get; set; }

		public UserType Type { get; set; }

		public bool UsePersonalMeetingId { get; set; }

		public string AccountId { get; set; }

		public long AccountNumber { get; set; }

		public string CmsUserId { get; set; }

		public string Company { get; set; }

		public CustomAttribute[] CustomAttributes { get; set; }

		public string EmployeeId { get; set; }

		public string[] GroupIds { get; set; }

		public string HostKey { get; set; }

		public string[] ImGroupIds { get; set; }

		public string JId { get; set; }

		public string JobTitle { get; set; }

		public string Language { get; set; }

		public string Location { get; set; }

		public LoginType LoginType { get; set; }

		public string Manager { get; set; }

		public string PersonalMeetingUrl { get; set; }

		public PhoneNumber[] PhoneNumbers { get; set; }

		public string ProfilePictureUrl { get; set; }

		public string UnitedPlanType { get; set; }

		public string Pronouns { get; set; }

		public PronounDisplayType PronounsDisplay { get; set; }

		public string RoleId { get; set; }

		public UserStatus Status { get; set; }

		public string VanityUrl { get; set; }

		public bool IsVerified { get; set; }

		public override string ToString()
        {
			return "---------User's information---------\n"
				+ $"User Id: {Id}\n"
				+ $"User CreatedOn: {CreatedOn}\n"
				+ $"User Department: {Department}\n"
				+ $"User Email: {Email}\n"
				+ $"User Name: {Name}\n"
				+ $"User PersonalMeetingId: {PersonalMeetingId}\n"
				+ $"User Type: {Type}\n"
				+ $"User UsePersonalMeetingId: {UsePersonalMeetingId}\n"
				+ $"User AccountNumber: {AccountNumber}\n"
				+ $"User HostKey: {HostKey}\n"
				+ $"User LoginType: {LoginType}\n"
				+ $"User PronounsDisplay: {PronounsDisplay}\n"
				+ $"User Status: {Status}\n"
				+ $"User IsVerified: {IsVerified}\n"
				+ $"User LastLoginClientVersion: {LastLoginClientVersion}\n"
				+ $"User LastLogin: {LastLogin}\n"
				+ $"User RoleName: {RoleName}\n"
				+ $"User Timezone: {Timezone}\n"
				+ $"User AccountId: {AccountId}\n"
				+ $"User JId: {JId}\n"
				+ $"User JobTitle: {JobTitle}\n"
				+ $"User Language: {Language}\n"
				+ $"User Location: {Location}\n"
				+ $"User PersonalMeetingUrl: {PersonalMeetingUrl}\n";
				//+ $"User CmsUserId: {CmsUserId}\n"
				//+ $"User Company: {Company}\n"
				//+ $"User CustomAttributes: {CustomAttributes}\n"
				//+ $"User EmployeeId: {EmployeeId}\n"
				//+ $"User GroupIds: {GroupIds}\n"
				//+ $"User ImGroupIds: {ImGroupIds}\n"
				//+ $"User Manager: {Manager}\n"
				//+ $"User PhoneNumbers: {PhoneNumbers}\n"
				//+ $"User ProfilePictureUrl: {ProfilePictureUrl}\n"
				//+ $"User UnitedPlanType: {UnitedPlanType}\n"
				//+ $"User Pronouns: {Pronouns}\n"
				//+ $"User RoleId: {RoleId}\n"
				//+ $"User VanityUrl: {VanityUrl}\n";
		}
	}
}
