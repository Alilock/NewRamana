using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gender :BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Category> Categories { get; set; } = null!;


    }
}
