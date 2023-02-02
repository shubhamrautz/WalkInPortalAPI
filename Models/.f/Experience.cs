using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class Experience
    {
        public Experience()
        {
            ExpertiseTechnologies = new HashSet<ExpertiseTechnology>();
        }

        public int Id { get; set; }
        public decimal Years { get; set; }
        public string CurrentCtc { get; set; } = null!;
        public string ExpectedCtc { get; set; } = null!;
        public DateOnly? NoticePeriodEnd { get; set; }
        public string? NoticeDuration { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<ExpertiseTechnology> ExpertiseTechnologies { get; set; }
    }
}
