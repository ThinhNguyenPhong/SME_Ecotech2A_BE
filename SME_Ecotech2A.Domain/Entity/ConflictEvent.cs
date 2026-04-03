using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ConflictEvent
    {
        public Guid ConflictEventId { get; set; }
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public string ConflictType { get; set; } = null!;    // hotfix/support_escalation/cross_project/meeting_overload
        public Guid FromProjectId { get; set; }
        public string? ConflictNote { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysImpacted { get; set; }


        public Task Task { get; set; } = null!;
        public User User { get; set; } = null!;
        public Project FromProject { get; set; } = null!;
        public ICollection<TimesheetEntry> TimesheetEntries { get; set; } = new List<TimesheetEntry>();
    }
}
