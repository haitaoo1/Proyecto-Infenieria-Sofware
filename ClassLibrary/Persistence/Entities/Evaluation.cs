using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Boolean Accepted { set; get; }
        public string Comments { set; get; }
        public DateTime Date { set; get; }
        public int Id { set; get; }
        // public Paper Paper { get; set; }


    }
}
