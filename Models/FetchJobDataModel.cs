namespace WalkInPortalAPI.Models
{
    public class FetchJobDataModel
    {
        //Job Post Parameters
        public int JobPostId { get; set; }
        public string? title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string? Location { get; set; }
        public string? Internship { get; set; }

        public string? GeneralInstruction { get; set; }
        public string? ExamInstruction { get; set; }
        public string? SystemRequirements { get; set; }
        public string? ApplicationProcess { get; set; }
        public string Venue { get; set; } = null!;


        public IEnumerable<JobRole>? JobRoles { get; set; }
        public IEnumerable<JobTimeslot>? JobTimeslots { get; set; }
    }
    public partial class JobRole
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Requirement { get; set; }
        public string? Package { get; set; }
    }

    public partial class JobTimeslot
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

    }

}
