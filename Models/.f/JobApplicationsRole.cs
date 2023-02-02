using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class JobApplicationsRole
    {
        public int Id { get; set; }
        public int JobRoleId { get; set; }
        public int JobApplicationsId { get; set; }

        public virtual JobApplication JobApplications { get; set; } = null!;
        public virtual JobRole JobRole { get; set; } = null!;
    }
}
