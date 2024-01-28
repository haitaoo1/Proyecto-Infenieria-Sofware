using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
      
        public int Id { set; get; }
        public string Name { set; get; }
        [Required]
        public User Editor { get; set; }
        public virtual Magazine Magazine { get; set; }
        [InverseProperty("BelongingArea")]
        public virtual ICollection<Paper> Papers { get; set; }

        [InverseProperty("EvaluationPendingArea")]
        public virtual ICollection<Paper> EvaluationPending { get; set; }

        [InverseProperty("PublicationPendingArea")]
        public virtual ICollection<Paper> PublicationPending { get; set; }
    }
}
