using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class PreferredRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int JobRoleId { get; set; }

        public virtual JobRole JobRole { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
