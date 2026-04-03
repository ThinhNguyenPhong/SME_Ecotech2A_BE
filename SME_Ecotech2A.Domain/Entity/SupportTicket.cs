using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class SupportTicket
    {
        public Guid SupportTicketId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? PhaseId { get; set; }
        public Guid ReporterId { get; set; }
        public Guid? AssigneeId { get; set; }
        public string? TicketCode { get; set; }             
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;        // bug_report/feature_request/usage_question/incident
        public string Priority { get; set; } = null!;        // low/medium/high/urgent
        public string Status { get; set; } = null!;          // open/assigned/in_progress/resolved/closed
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ResolvedAt { get; set; }

        public Project Project { get; set; } = null!;
        public Phase? Phase { get; set; }
        public User Reporter { get; set; } = null!;
        public User? Assignee { get; set; }
    }
}
