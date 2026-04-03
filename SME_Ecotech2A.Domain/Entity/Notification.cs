using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Notification
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; } = null!;            // milestone/overdue/overload/system
        public string Title { get; set; } = null!;
        public string? Subtitle { get; set; }
        public bool IsRead { get; set; } = false;
        public string? LinkTo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User User { get; set; } = null!;
    }
}
