using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class RegressionItem
    {
        public Guid RegressionItemId { get; set; }
        public Guid BugId { get; set; }
        public string TestCase { get; set; } = null!;
        public string Status { get; set; } = null!;          // pass/fail/pending
        public string? Note { get; set; }
        public Guid VerifiedBy { get; set; }
        public DateTime VerifiedAt { get; set; } = DateTime.Now;

        public BugTicket BugTicket { get; set; } = null!;
        public User VerifiedByUser { get; set; } = null!;
    }
}
