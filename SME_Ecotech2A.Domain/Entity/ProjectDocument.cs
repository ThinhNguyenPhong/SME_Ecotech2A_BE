using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ProjectDocument
    {
        public Guid DocumentId { get; set; }
        public Guid ProjectId { get; set; }
        public string DocType { get; set; } = null!;
        public string DocName { get; set; } = null!;
        public string FileUrl { get; set; } = null!;
        public Guid UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.Now;

        public Project Project { get; set; } = null!;
        public User UploadedByUser { get; set; } = null!;
    }
}
