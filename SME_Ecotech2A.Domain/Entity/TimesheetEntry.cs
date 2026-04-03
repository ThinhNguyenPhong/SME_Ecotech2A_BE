using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class TimesheetEntry
    {
        public Guid TimesheetId { get; set; }
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public DateTime WorkDate { get; set; }
        public string WorkType { get; set; } = null!;        // development/review/meeting/support/testing
        public decimal Hours { get; set; }
        public bool IsOT { get; set; } = false;
        public decimal? HoursOT { get; set; }
        public Guid? ConflictEventId { get; set; }

     
        public User User { get; set; } = null!;
        public Task Task { get; set; } = null!;
        public ConflictEvent? ConflictEvent { get; set; }
    }
}
