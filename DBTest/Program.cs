using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Magazine.Entities;
using Magazine.Persistence;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            CreateSampleDB(dal);
        }

        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();
            Console.WriteLine("Creando los datos y almacenándolos en la BD");
            Console.WriteLine("===========================================");
            Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
            User u1 = new User("1352", "victor", "Jefe", false, "ninguna", "vmbarber@gmail.com", "Jefe", "1352",true);
            dal.Insert<User>(u1);
            dal.Commit();

            
            Console.WriteLine("\n// CREACIÓN DEL RESPONSABLE DE UN ARTÍCULO");
            User u2 = new User("7392", "fernando", "Responsable", false, "ninguna", "ferbui@gmail.com", "Responsable", "7392",true);
            dal.Insert<User>(u2);
            dal.Commit();

            Console.WriteLine("\n// CREACIÓN DEL EDITOR DEL ÁREA");
            User u3 = new User("1284", "Haitao", "Editor", false, "ninguna", "hwu@gmail.com", "Editor", "1284", true);
            dal.Insert<User>(u3);
            dal.Commit();

        

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista eSport", u1);
            u1.Magazine = m;

            Area area = new Area("Videojuegos", u2, m);
            Issue issue = new Issue(10, m, 1000, 100);
            m.Areas.Add(area);

            m.Issues.Add(issue);

            Paper paper = new Paper("hola Fernando", new DateTime(2022, 10, 25), area, u2);

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            Console.ReadKey();

            // Populate here the rest of the database with data

        }

    }

}