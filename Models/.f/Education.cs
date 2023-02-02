using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class Education
    {
        public int Id { get; set; }
        public short PassingYear { get; set; }
        public decimal Percentage { get; set; }
        public string? CollegeLocation { get; set; }
        public int UserId { get; set; }
        public int StreamId { get; set; }
        public int QualificationId { get; set; }
        public int CollegeId { get; set; }

        public virtual College College { get; set; } = null!;
        public virtual Qualification Qualification { get; set; } = null!;
        public virtual Stream Stream { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
