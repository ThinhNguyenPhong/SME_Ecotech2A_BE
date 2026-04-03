using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class TaskProgressLog
    {
        public Guid ProgressLogId { get; set; }
        public Guid TaskId { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime ProgressDate { get; set; }
        public int PercentDone { get; set; }                 // 0-100
        public string? WorkContent { get; set; }
        public decimal? HoursLogged { get; set; }
        public bool IsOT { get; set; } = false;
        public decimal? HoursOTLogged { get; set; }            
        public string? BlockerReason { get; set; }          // development/review/meeting/support/testing
        public string? DelayReasonType { get; set; }
        public string? DelayReasonNote { get; set; }
        public string? Note { get; set; }

        
        public Task Task { get; set; } = null!;
        public User UpdatedByUser { get; set; } = null!;
    }
}
