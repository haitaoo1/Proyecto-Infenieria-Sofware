using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id { set; get; }
        public string Name { set; get; }

        [Required]

        public virtual User ChiefEditor { set; get; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
    }
}
