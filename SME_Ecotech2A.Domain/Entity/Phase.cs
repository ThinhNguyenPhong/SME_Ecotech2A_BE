using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Phase
    {
        public Guid PhaseId { get; set; }
        public Guid ProjectId { get; set; }
        public string PhaseName { get; set; } = null!;
        public string PhaseType { get; set; } = null!;       // analysis/design/development/testing/deployment/support
        public string? Description { get; set; }
        public DateTime PlannedStart { get; set; }
        public DateTime PlannedEnd { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public string Status { get; set; } = null!;          // not_started/in_progress/completed/delayed
        public string? BaselineAdjustmentLog { get; set; }

      
        public Project Project { get; set; } = null!;
        public ICollection<Milestone> Milestones { get; set; } = new List<Milestone>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        public ICollection<ReviewSession> ReviewSessions { get; set; } = new List<ReviewSession>();
        public ICollection<BugTicket> BugTickets { get; set; } = new List<BugTicket>();
        public ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();
    }
}
