using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class JobApplication
    {
        public JobApplication()
        {
            JobApplicationsRoles = new HashSet<JobApplicationsRole>();
        }

        public int Id { get; set; }
        public string ResumeUrl { get; set; } = null!;
        public string DownloadUrl { get; set; } = null!;
        public int JobPostId { get; set; }
        public int UserId { get; set; }
        public int JobTimeslotId { get; set; }

        public virtual JobPost JobPost { get; set; } = null!;
        public virtual JobTimeslot JobTimeslot { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<JobApplicationsRole> JobApplicationsRoles { get; set; }
    }
}
