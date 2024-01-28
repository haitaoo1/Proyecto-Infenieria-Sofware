using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public Person()
        {
            this.CoAuthoredPapers = new List<Paper>();
        }

        
        public Person(string id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;

            //Colecciones
            this.CoAuthoredPapers = new List<Paper>();
        }
    }

}

