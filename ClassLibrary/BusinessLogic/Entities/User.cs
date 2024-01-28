using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User
    {
        public User()
        {
            this.MainAuthoredPapers = new List<Paper>();
        }
        public User(string id, string name, string surname, Boolean alerted, string areaofinterest, string email, string login, string password, bool magazineSuscriber) :base(id, name, surname)
        {
            this.MagazineSuscriber = magazineSuscriber;
            this.Alerted = alerted;
            this.AreasOfInterest = areaofinterest;
            this.Email = email;
            this.Login = login;
            this.Password = password;

            //Colecciones
            this.MainAuthoredPapers = new List<Paper>();
        }
        public Area getAreaEditor() {
            return this.Area;
        }
        public Magazine getMagazineEditor(){
            return this.Magazine;  
        }
        

    }
}
