using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public int? ParentId { get; set; }
        public virtual Category? Parent { get; set; }
        public virtual ICollection<Category>? Children { get; set; }
        public string Name { get; set; } = null!;

        [NotMapped]
        public string? ParentName
        {
            get
            {
                return this.Parent?.Name;
            }
        }
    }
}
