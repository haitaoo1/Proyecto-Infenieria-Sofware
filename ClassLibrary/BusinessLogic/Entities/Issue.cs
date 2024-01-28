using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue()
        {
            this.PublishedPapers = new List<Paper>();
        }
        public Issue(int number, Magazine magazine, float price, float discount, DateTime uploadDate)
        {
            this.Number = number;
            this.Discount = discount;
            this.Price = price;

            //Relaciones a 1
            this.Magazine = magazine;

            //Colecciones
            this.PublishedPapers = new List<Paper>();

            this.PublicationDate = uploadDate;


        }
        public List<Paper> getListaPapers()
        {
            return (List<Paper>)this.PublishedPapers;
        }
        public void addPublishedPapers(Paper p)
        {
            this.PublishedPapers.Add(p);    
        }

    }

}
