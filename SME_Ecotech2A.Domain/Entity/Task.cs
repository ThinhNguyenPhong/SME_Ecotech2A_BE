using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid PhaseId { get; set; }
        public Guid AssigneeId { get; set; }
        public Guid AssignerId { get; set; }
        public string? TaskCode { get; set; }               
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string TaskType { get; set; } = null!;        // feature/bug_fix/research/code_review/testing/documentation/devops/design
        public string Priority { get; set; } = null!;        // low/medium/high/critical
        public string Status { get; set; } = null!;          // todo/in_progress/review/done/cancelled/on_hold
        public DateTime PlannedStart { get; set; }
        public DateTime PlannedEnd { get; set; }
        public int? EstimateHours { get; set; }
        public string? DelayReasonType { get; set; }         // resource_conflict/scope_change/dependency/external

       
        public Project Project { get; set; } = null!;
        public Phase Phase { get; set; } = null!;
        public User Assignee { get; set; } = null!;
        public User Assigner { get; set; } = null!;
        public ICollection<TaskDependency> PredecessorDependencies { get; set; } = new List<TaskDependency>();
        public ICollection<TaskDependency> SuccessorDependencies { get; set; } = new List<TaskDependency>();
        public ICollection<TaskProgressLog> TaskProgressLogs { get; set; } = new List<TaskProgressLog>();
        public ICollection<TimesheetEntry> TimesheetEntries { get; set; } = new List<TimesheetEntry>();
        public ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();
        public ICollection<ConflictEvent> ConflictEvents { get; set; } = new List<ConflictEvent>();
        public ICollection<BugTicket> BugTickets { get; set; } = new List<BugTicket>();
    }
}
