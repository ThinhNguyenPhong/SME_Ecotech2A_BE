using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class Holiday
    {
        public Guid HolidayId { get; set; }
        public string HolidayName { get; set; } = null!;
        public DateTime HolidayDate { get; set; }
        public string HolidayType { get; set; } = null!;     // fixed/compensatory/custom
        public string? Note { get; set; }
    }
}
