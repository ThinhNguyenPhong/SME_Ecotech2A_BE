using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ProjectMember
    {
        public Guid ProjectMemberId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
        public float AllocationPct { get; set; } = 100;      // 0-100
        public DateTime JoinedAt { get; set; }
        public DateTime? LeftAt { get; set; }


        public Project Project { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
