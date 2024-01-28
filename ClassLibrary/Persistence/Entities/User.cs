using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User:Person
    {
        public Boolean Alerted { set; get; }
        public string AreasOfInterest { set; get; }
        public string Email { set; get; }
        [Key]
        public string Login { set; get; }
        public bool MagazineSuscriber { set; get; }
        public string Password { set; get; }
        public virtual Area Area { get; set; }
        public virtual Magazine Magazine { get; set; }
        public virtual ICollection<Paper> MainAuthoredPapers { get; set; }
    }
}
