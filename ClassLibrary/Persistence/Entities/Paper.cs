using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public DateTime UploadDate { set; get; }
        public virtual Evaluation Evaluation { set; get; }
        public virtual Issue Issue { set; get; }
        [InverseProperty("PublicationPending")]
        public virtual Area PublicationPendingArea { set; get; }
        [InverseProperty("EvaluationPending")]
        public virtual Area EvaluationPendingArea { set; get; }
        [InverseProperty("Papers")]
        public virtual Area BelongingArea { set; get; }
        [Required]
        public virtual User Responsible { set; get; }
        public virtual ICollection<Person> CoAuthors{set; get;}


        }
}
