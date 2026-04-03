using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Milestone
    {
        public Guid MilestoneId { get; set; }
        public Guid PhaseId { get; set; }
        public string MilestoneName { get; set; } = null!;
        public DateTime PlannedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Status { get; set; } = null!;          // pending/achieved/missed/at_risk

        public Phase Phase { get; set; } = null!;
        public ICollection<ReviewSession> ReviewSessions { get; set; } = new List<ReviewSession>();
    }
}
