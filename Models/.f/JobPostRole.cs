using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class JobPostRole
    {
        public int Id { get; set; }
        public string Package { get; set; } = null!;
        public int JobPostId { get; set; }
        public int JobRoleId { get; set; }

        public virtual JobPost JobPost { get; set; } = null!;
        public virtual JobRole JobRole { get; set; } = null!;
    }
}
