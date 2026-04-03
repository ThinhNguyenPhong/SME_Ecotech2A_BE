using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; } = null!;
        public string? Industry { get; set; }
        public string Status { get; set; } = null!;          // active / inactive / prospect
        public string? TaxCode { get; set; }
        public string? Website { get; set; }
        public string? Address { get; set; }
        public string? AvatarUrl{ get; set; }             
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public ICollection<ClientContact> ClientContacts { get; set; } = new List<ClientContact>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
