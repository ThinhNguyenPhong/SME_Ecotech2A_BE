using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ReviewSession
    {
        public Guid ReviewId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? PhaseId { get; set; }
        public Guid? MilestoneId { get; set; }
        public string ReviewType { get; set; } = null!;      // internal/client/demo/sprint_review/gate_review
        public DateTime ScheduledAt { get; set; }
        public string Status { get; set; } = null!;          // scheduled/completed/cancelled/rescheduled
 
        public Project Project { get; set; } = null!;
        public Phase? Phase { get; set; }
        public Milestone? Milestone { get; set; }
        public ICollection<ReviewFeedback> ReviewFeedbacks { get; set; } = new List<ReviewFeedback>();
    }
}
