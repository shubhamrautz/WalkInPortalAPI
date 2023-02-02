using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class UserFamiliarTechnology
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? TechnologyId { get; set; }
        public string? OtherTechnology { get; set; }

        public virtual Technology? Technology { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
