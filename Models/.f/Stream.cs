using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class Stream
    {
        public Stream()
        {
            Educations = new HashSet<Education>();
        }

        public int Id { get; set; }
        public string Stream1 { get; set; } = null!;

        public virtual ICollection<Education> Educations { get; set; }
    }
}
