using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class JobPostInstruction
    {
        public int Id { get; set; }
        public string? GeneralInstruction { get; set; }
        public string? ExamInstruction { get; set; }
        public string? SystemRequirements { get; set; }
        public string? ApplicationProcess { get; set; }
        public string Venue { get; set; } = null!;
        public int JobPostId { get; set; }

        public virtual JobPost JobPost { get; set; } = null!;
    }
}
