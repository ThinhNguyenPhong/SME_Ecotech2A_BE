using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Domain.Entity
{
    public class SystemSetting
    {
        public Guid SettingId { get; set; }
        public string Category { get; set; } = null!;        // task_type/delay_reason/blocker_type
        public string Label { get; set; } = null!;           // nhãn hiển thị UI (tiếng Việt)
        public string Value { get; set; } = null!;           // giá trị lưu DB (snake_case)
        public int SortOrder { get; set; } = 0;
        public bool IsActive { get; set; } = true;
    }
}
