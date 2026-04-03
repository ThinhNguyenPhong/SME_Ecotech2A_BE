using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class BugAttachment
    {
        public Guid AttachmentId { get; set; }
        public Guid BugId { get; set; }
        public string FileName { get; set; } = null!;
        public string FileUrl { get; set; } = null!;
        public Guid UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.Now;

        public BugTicket BugTicket { get; set; } = null!;
        public User UploadedByUser { get; set; } = null!;
    }
}
