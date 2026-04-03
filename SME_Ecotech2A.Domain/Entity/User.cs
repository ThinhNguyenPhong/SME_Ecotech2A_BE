using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class User
    {
        public Guid UserId { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid RoleId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string HashPassword { get; set; } = null!;
        //public string? Title { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Department? Department { get; set; }
        public Role Role { get; set; } = null!;
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
        public ICollection<Task> AssignedTasks { get; set; } = new List<Task>();
        public ICollection<Task> AssignedByTasks { get; set; } = new List<Task>();
        public ICollection<TaskProgressLog> TaskProgressLogs { get; set; } = new List<TaskProgressLog>();
        public ICollection<TimesheetEntry> TimesheetEntries { get; set; } = new List<TimesheetEntry>();
        public ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();
        public ICollection<ProjectDocument> ProjectDocuments { get; set; } = new List<ProjectDocument>();
        public ICollection<ConflictEvent> ConflictEvents { get; set; } = new List<ConflictEvent>();
        public ICollection<ReviewFeedback> ReviewFeedbacks { get; set; } = new List<ReviewFeedback>();
        public ICollection<BugTicket> ReportedBugs { get; set; } = new List<BugTicket>();
        public ICollection<BugTicket> AssignedBugs { get; set; } = new List<BugTicket>();
        public ICollection<BugTicket> VerifiedBugs { get; set; } = new List<BugTicket>();
        public ICollection<BugAttachment> BugAttachments { get; set; } = new List<BugAttachment>();
        public ICollection<BugRCAHistory> BugRcaHistories { get; set; } = new List<BugRCAHistory>();
        public ICollection<SupportTicket> ReportedSupportTickets { get; set; } = new List<SupportTicket>();
        public ICollection<SupportTicket> AssignedSupportTickets { get; set; } = new List<SupportTicket>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}
