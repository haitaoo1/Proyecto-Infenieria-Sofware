using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {

        public Area()
        {
            this.Papers = new List<Paper>();
            this.EvaluationPending = new List<Paper>();
            this.PublicationPending = new List<Paper>();
        }
        public Area(string name, User editor, Magazine magazine)
        {
            //this.Id = id;  
            this.Name = name;

            //Relaciones a 1
            this.Editor = editor;
            this.Magazine = magazine;

            //Colecciones
            this.EvaluationPending = new List<Paper>();
            this.Papers = new List<Paper>();
            this.PublicationPending = new List<Paper>();
        }
        public void insertarPaper(Paper paper)
        {
            this.Papers.Add(paper);

        }
        public List<Paper> getListPapers()
        {
            return (List<Paper>)/*Casting*/ this.Papers;
        }
        
        public void addEvalPeningPaper(Paper p)
        {
            this.EvaluationPending.Add(p);
        }
        public void addPubliPeningPaper(Paper p)
        {
            this.PublicationPending.Add(p);
        }

        public void RemoveEvalPeningPaper(Paper p)
        {
            this.EvaluationPending.Remove(p);
        }
        public void RemovePubliPeningPaper(Paper p)
        {
            this.PublicationPending.Remove(p);
        }


        public List<Paper> getEvaluationPending()
        {
            return (List<Paper>) this.EvaluationPending;
        }
        public List<Paper> getPublicationPending()
        {
            return (List<Paper>)this.PublicationPending;
        }

    }
 }

