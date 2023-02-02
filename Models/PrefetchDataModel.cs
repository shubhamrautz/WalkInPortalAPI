
namespace WalkInPortalAPI.Models
{
    public class PrefetchDataModel
    {

        public IEnumerable<Role>? Roles { get; set; }
        public IEnumerable<Qualification>? Qualifications { get; set; }
        public IEnumerable<QualificationStream>? Streams { get; set; }
        public IEnumerable<College>? Colleges { get; set; }
        public IEnumerable<Technology>? Technologies { get; set; }

    }

    public class Role
    {
        public int? id { get; set; }
        public string? name { get; set; }
    }

    public class Qualification
    {
        public int? id { get; set; }
        public string? qualification { get; set; }
    }

    public class QualificationStream
    {
        public int? id { get; set; }
        public string? stream { get; set; }
    }

    public class College
    {
        public int? id { get; set; }
        public string? college_name { get; set; }
    }

    public class Technology
    {
        public int? id { get; set; }
        public string? technology { get; set; }
    }
}
