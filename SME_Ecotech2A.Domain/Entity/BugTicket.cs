using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class BugTicket
    {
        public Guid BugId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? PhaseId { get; set; }
        public Guid? TaskId { get; set; }
        public Guid ReporterId { get; set; }
        public Guid AssigneeId { get; set; }
        public Guid? VerifyBy { get; set; }
        public string? BugCode { get; set; }                
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? StepsToReproduce { get; set; }
        public string? Environment { get; set; }             // Staging/Production/Dev
        public string Severity { get; set; } = null!;        // critical/high/medium/low
        public string Status { get; set; } = null!;          // open/in_progress/fixed/verified/closed/reopened
        public bool RepeatedFlag { get; set; } = false;
        public int RepeatedCount { get; set; } = 0;
        public bool ImpactTimeline { get; set; } = false;
        public bool RcaRequired { get; set; } = false;
        public string? RootCauseType { get; set; }           // logic_error/missing_requirement/env_issue/third_party/config
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ResolvedAt { get; set; }

        public Project Project { get; set; } = null!;
        public Phase? Phase { get; set; }
        public SME_Ecotech2A.Domain.Entity.Task? Task { get; set; }
        public User Reporter { get; set; } = null!;
        public User Assignee { get; set; } = null!;
        public User? VerifyByUser { get; set; }
        public ICollection<BugAttachment> BugAttachments { get; set; } = new List<BugAttachment>();
        public ICollection<BugRCAHistory> BugRcaHistories { get; set; } = new List<BugRCAHistory>();
        public ICollection<RegressionItem> RegressionItems { get; set; } = new List<RegressionItem>();
    }
}
