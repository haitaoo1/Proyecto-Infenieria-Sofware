﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation()
        {

        }
        public Evaluation(Boolean accepted, string comments, DateTime date)
        {
            this.Accepted = accepted;
            this.Comments = comments;
            this.Date = date;
        }

        
    }
}
