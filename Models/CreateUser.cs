namespace WalkInPortalAPI.Models
{
    public class CreateUser
    {
        //User Parameters
        //public int? UserId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? PhoneNo { get; set; }
        public string? ResumeLink { get; set; }
        public string? PortfolioLink { get; set; }
        public string? Referal { get; set; }
        public sbyte? SendMail { get; set; }
        public string? PreviouslyAppliedRole { get; set; }
        public int? ApplicantTypeId { get; set; }

        //Preffered Role
        public string? JobRoleId { get; set; }

        //Education Parameters
        public short? PassingYear { get; set; }
        public decimal? Percentage { get; set; }
        public string? CollegeLocation { get; set; }
        public int? StreamId { get; set; }
        public int? CollegeId { get; set; }
        public int? QualificationId { get; set; }

        //Experience Parameters

        public decimal? Years { get; set; }
        public string? CurrentCtc { get; set; } = null!;
        public string? ExpectedCtc { get; set; } = null!;
        public string? NoticePeriodEnd { get; set; }
        public string? NoticeDuration { get; set; }


        //Familiar Technology
        public string? FamiliarTechnologyId { get; set; }
        public string? OtherTechnology { get; set; }


        //Expertise Technology        
        public string? ExpertiseTechnologyId { get; set; }
        public string? OtherExpertiseTechnology { get; set; }

    }
}
