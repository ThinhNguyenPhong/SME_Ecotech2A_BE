using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Project
    {
        public Guid ProjectId { get; set; }
        public Guid ClientId { get; set; }
        public Guid OwnerId { get; set; }
        public string ProjectCode { get; set; } = null!;    
        public string ProjectName { get; set; } = null!;
        public string Status { get; set; } = null!;          // planning/inprogress/on_hold/completed/cancelled
        public string Priority { get; set; } = null!;        // low/medium/high/critical
        public string? Description { get; set; }
        public DateTime PlannedStart { get; set; }
        public DateTime PlannedEnd { get; set; }
        public int WarrantyMonths { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        
        public Client Client { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
        public ICollection<Phase> Phases { get; set; } = new List<Phase>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        public ICollection<ProjectDocument> ProjectDocuments { get; set; } = new List<ProjectDocument>();
        public ICollection<ReviewSession> ReviewSessions { get; set; } = new List<ReviewSession>();
        public ICollection<BugTicket> BugTickets { get; set; } = new List<BugTicket>();
        public ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();
        public ICollection<ConflictEvent> ConflictEvents { get; set; } = new List<ConflictEvent>();
    }
}
