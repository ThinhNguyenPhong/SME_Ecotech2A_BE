using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class TaskDependency
    {
        public Guid DependencyId { get; set; }
        public Guid PredecessorTaskId { get; set; }
        public Guid SuccessorTaskId { get; set; }
        public string DependencyType { get; set; } = null!;  // FS / SS / FF / SF

        
        public Task PredecessorTask { get; set; } = null!;
        public Task SuccessorTask { get; set; } = null!;
    }
}
