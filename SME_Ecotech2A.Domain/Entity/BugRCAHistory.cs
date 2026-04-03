using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class BugRCAHistory
    {
        public Guid RcaId { get; set; }
        public Guid BugId { get; set; }
        public int OccurrenceNo { get; set; }                // 1 = lần đầu, 2 = tái phát lần 1, ...
        public string RootCauseType { get; set; } = null!;   // logic_error/config/env/requirement_gap/third_party
        public string RootCauseNote { get; set; } = null!;
        public string Solution { get; set; } = null!;
        public string PreventionAction { get; set; } = null!;
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public BugTicket BugTicket { get; set; } = null!;
        public User CreatedByUser { get; set; } = null!;
    }
}
