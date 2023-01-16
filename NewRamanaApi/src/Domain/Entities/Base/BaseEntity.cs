using Domain.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int? CreatedByUserId { get; set; }
        public virtual AppUser CreatedByUser { get; set; } = null!;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(4);
        public DateTime? DeletedDate { get; set; }
        public int? DeletedByUserId { get; set; }
        public virtual AppUser DeletedByUser { get; set; } = null!;
    }
}
