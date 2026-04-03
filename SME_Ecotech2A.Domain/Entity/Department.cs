using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public Guid? ManagerID { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public User? Manager { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
