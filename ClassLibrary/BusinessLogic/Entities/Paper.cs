using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            this.CoAuthors = new List<Person>();
        }
        public Paper(string title, DateTime uploadDate, Area belongingArea, User responsible)
        {
            this.Title = title;
            this.UploadDate = uploadDate;
            

            //Relaciones a 1
            this.BelongingArea = belongingArea;
            this.Responsible = responsible;

            //Colecciones
            this.CoAuthors = new List<Person>();
            this.CoAuthors.Add(responsible);

        }

        public Area AreaPaper() {
            return this.BelongingArea;
        }
        public void setCoAuthorsList(List<Person> coAuthors) {
            this.CoAuthors = coAuthors;
        }
        public List<Person> getCoAuthorsList()
        {
            return this.getCoAuthorsList();
        }
        public User getResponsible() { return this.Responsible; }
        public void setEvaliation(Evaluation evaluation)
        {
            this.Evaluation = evaluation;
        }
        public void setPublicationPendingArea(Area a)
        { 
            this.PublicationPendingArea = a;
        }

        public void setEvaluationPendingArea(Area a)
        {
            this.EvaluationPendingArea = a;
        }

        public void removeEvaluationPendingArea(Area a)
        { 
            this.EvaluationPendingArea = null;
        }
        public void removePublicationPendingArea(Area a)
        {
            this.EvaluationPendingArea = null;
        }

        //public List<Paper> getPapersPendPub() {
        //    return  this.PublicationPendingArea;
        //}
        //public List<(Paper, String)> getPapersPendEval()
        //{
        //    return List < (Paper, String) > this.EvaluationPendingArea.Paper;
        //}
    }

        //para el caso de confeccionar ejemplar
        // crear un metodo que devuelva el area de un paper y usamos este
        //metodo para monstar el area de los paper que hemos insertado en la lista
        //publication pending
   }

