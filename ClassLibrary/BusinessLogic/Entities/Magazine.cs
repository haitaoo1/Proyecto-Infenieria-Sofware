using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            this.Issues = new List<Issue>();
            this.Areas = new List<Area>();
        }
        public Magazine(string name, User chiefeditor)
        {
            this.Name = name;

            //Relaciones a 1
            this.ChiefEditor = chiefeditor;

            //Colecciones
            this.Areas = new List<Area>();
            this.Issues = new List<Issue>();

        }
        public List<Area> getListaAreas(){
            return (List<Area>) this.Areas;
        }
        public List<Issue> getListaIssues()
        {
            return (List<Issue>) this.Issues;
        }
        public User getChiefEditor()
        {
            return (User) this.ChiefEditor;
        }
        public void addIssues(Issue i)
        {
            this.Issues.Add(i);
        }
    }
}
