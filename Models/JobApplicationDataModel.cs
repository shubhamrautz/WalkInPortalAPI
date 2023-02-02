
namespace WalkInPortalAPI.Models
{
    public class JobApplicationDataModel
    {
        public string ResumeUrl { get; set; } = null!;
        public string? JobPostIds { get; set; }
        public int UserId { get; set; }
        public int JobTimeslotId { get; set; }
    }
}