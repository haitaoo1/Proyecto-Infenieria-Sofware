using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public int Id { set; get; }
        public int Number { set; get; }
        public float Price { set; get; }
        public float Discount { set; get; }

        public DateTime? PublicationDate { set; get; }

        [Required]

        public virtual Magazine Magazine { set; get; }
        public virtual ICollection<Paper> PublishedPapers { get; set; }
    }
    
}
