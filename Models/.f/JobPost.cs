using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class JobPost
    {
        public JobPost()
        {
            JobApplications = new HashSet<JobApplication>();
            JobPostInstructions = new HashSet<JobPostInstruction>();
            JobPostRoles = new HashSet<JobPostRole>();
            JobTimeslots = new HashSet<JobTimeslot>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string Location { get; set; } = null!;
        public string? Internship { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
        public virtual ICollection<JobPostInstruction> JobPostInstructions { get; set; }
        public virtual ICollection<JobPostRole> JobPostRoles { get; set; }
        public virtual ICollection<JobTimeslot> JobTimeslots { get; set; }
    }
}
