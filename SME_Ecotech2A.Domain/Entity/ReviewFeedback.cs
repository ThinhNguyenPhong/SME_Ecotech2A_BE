using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ReviewFeedback
    {
        public Guid FeedbackId { get; set; }
        public Guid ReviewId { get; set; }
        public string FeedbackType { get; set; } = null!;    // bug/improvement/question/approval/change_request
        public string Severity { get; set; } = null!;        // critical/major/minor/info
        public string Description { get; set; } = null!;
        public string ActionStatus { get; set; } = null!;    // open/in_progress/resolved/rejected/deferred
        public Guid? AssigneeId { get; set; }

        public ReviewSession ReviewSession { get; set; } = null!;
        public User? Assignee { get; set; }
    }
}
