using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class ClientContact
    {
        public Guid ContactId { get; set; }
        public Guid ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string? Title { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsPrimary { get; set; } = false;
        public string? Note { get; set; }

      
        public Client Client { get; set; } = null!;
    }
}
