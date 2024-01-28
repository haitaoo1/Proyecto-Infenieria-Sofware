using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Magazine.Services;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;

namespace Magazine.Services
{
    public class MagazineService : IMagazineService
    {
        private readonly IDAL dal;

        public MagazineService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "ptheboss@gmail.com", "theboss", "1234", true);
            AddUser(u1);

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            AddMagazine(m);

            User u2 = new User("2345", "Javier", "Garcia", false, "la mia", "jgarcia@gmail.com", "jgarcia", "1234", true);
            AddUser(u2);
            Area a1 = new Area("Area 1", u2, m);
            AddArea(a1);

            User u3 = new User("3456", "Mª Carmen", "Jimenez", false, "la mia por supuesto", "mcjimenez@gmail.com", "mcjimenez", "1234", true);
            AddUser(u3);

            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

            // De regalo
            User u4 = new User("4567", "Juan", "Campeador", false, "la mejor", "jcampeador@gmail.com", "jcampeador", "1234", true);
            AddUser(u4);



            Paper p1 = new Paper("Prueba1", DateTime.Now, a1, u2);
            AddPaper(p1);

            Paper p2 = new Paper("Prueba2", DateTime.Now, a2, u3);
            AddPaper(p2);

            Paper p3 = new Paper("Prueba3", DateTime.Now, a1, u2);
            AddPaper(p3);
            Paper p4 = new Paper("Prueba4", DateTime.Now, a2, u2);
            AddPaper(p4);

            Paper p5 = new Paper("Prueba5", DateTime.Now, a1, u2);
            AddPaper(p5);

            Paper p6 = new Paper("Prueba6", DateTime.Now, a2, u3);
            AddPaper(p6);

            Paper p7 = new Paper("Prueba7", DateTime.Now, a1, u2);
            AddPaper(p7);

            Paper p8 = new Paper("Prueba8", DateTime.Now, a1, u3);
            AddPaper(p8);

            a1.addEvalPeningPaper(p1);
            a1.addPubliPeningPaper(p3);
            a1.addEvalPeningPaper(p7);
            a1.addPubliPeningPaper(p8);

            a2.addEvalPeningPaper(p2);
            a2.addPubliPeningPaper(p4);

            Issue I1 = new Issue(1111, m, 10000, 10, DateTime.Now); ;
            Issue T2 = new Issue(1212, m, 1000, 5, DateTime.Now);
            AddIssue(T2);
            I1.addPublishedPapers(p5);
            I1.addPublishedPapers(p6);
            AddIssue(I1);

            m.addIssues(I1);


            dal.Commit();


        }


        public bool esChiefEditor() { return UsuarioIniciado.Magazine != null; }
        public bool esEditorArea() { return UsuarioIniciado.Area != null; }

        public bool esUsuario() { return UsuarioIniciado.Magazine == null && UsuarioIniciado.Area == null; }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }


        public void AddMagazine(Magazine.Entities.Magazine magazine)
        {
            // Restricción: No puede haber dos revistas con el mismo nombre
            if (!dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == magazine.Name).Any())
            {
                dal.Insert<Magazine.Entities.Magazine>(magazine);
                dal.Commit();
            }
            else throw new ServiceException("Magazine with name " + magazine.Name + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with name " + area.Name + " already exists.");
        }
        public void AddIssue(Issue Issues)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Issue>(x => x.Number == Issues.Number).Any())
            {
                dal.Insert<Issue>(Issues);
                dal.Commit();
            }
            else throw new ServiceException("Issue with number " + Issues.Number + " already exists.");
        }



        // A partid de aquí escribid vuestras implementaciones

        public void AddUser(User user)
        {
            // no puede haber dos usuarios con el mismo nombre
            if (!dal.GetWhere<User>(x => x.Name == user.Name).Any())
            {
                dal.Insert<User>(user);
                dal.Commit();
            }
            else throw new ServiceException("usuario with name " + user.Name + " already exists.");

        }

        public void AddPaper(Paper paper)
        {
            // no puede haber dos papers iguales
            if (!dal.GetWhere<Paper>(x => x.Title == paper.Title).Any())
            {
                dal.Insert<Paper>(paper);
                dal.Commit();
            }
            else throw new ServiceException("Paper with name " + paper.Title + " already exists.");

        }



        public bool existeArea(string area)
        {

            if (dal.GetWhere<Area>(x => x.Name == area).Any())
            {
                return true;
            }
            else return false;

        }

        public Area comprabarArea(string area)
        {
            Area ExisteArea = null;

            if (dal.GetWhere<Area>(x => x.Name == area).Any())
            {
                ExisteArea = dal.GetWhere<Area>(x => x.Name == area).First();
            }
            else throw new ServiceException("Area with name " + area + " doesn´t exists.");

            return ExisteArea;
        }
        public List<Area> AllAreas()
        {
            List<Area> areas = dal.GetAll<Area>().ToList();
            return areas;
        }

        // Registrar Usuario
        public void RegistrarUsuario(string id, string nombre, string apellidos, string email, string areasDeInteres, string login, string password, bool alerta)
        {
            if (dal.GetWhere<User>(x => x.Login == login).Any())
            {
                throw new ServiceException("Login ya existente");
            }
            AddUser(new User(id, nombre, apellidos, alerta, email, areasDeInteres, login, password, true));
            dal.Commit();

        }

        //Usuario que esta iniciado

        public User UsuarioIniciado = new User(); //creamos el usuario Iniciado

        // Iniciar sesion

        public User IniciarSesion(string login, string password)
        {

            //if (dal.GetWhere<User>(x => x.Login == login && x.Password != password).Any())
            //{
            //    throw new ServiceException("Contraseña introducida incorrecta");
            //}

            //if (dal.GetWhere<User>(x => x.Login != login && x.Password == password).Any())
            //{
            //    throw new ServiceException("Usuario introducida no existente");
            //}
            if (dal.GetWhere<User>(x => x.Login == login && x.Password == password).Any())
            {
                User user = dal.GetWhere<User>(x => x.Login == login && x.Password == password).First();

                UsuarioIniciado = user;
                return user;
            }
            else throw new ServiceException("El usuario no esta registrado");


        }


        //METODO PARA MOVER DESDE EVALUATION A PUBLICATION
        public void MoverEvaluationAPublication(string area, string paper)
        {

            // recuperar la lista de todos los objetos de la clase Area desde la BD
            List<Area> areas = dal.GetAll<Area>().ToList();
            Area area1 = null;

            //Busca el area introducido en la lista de  areas . Si esta se devuelve en area 1 sino se devuelve null
            foreach (var areaComp in areas)
            {
                if (areaComp.Name == area)
                {
                    area1 = areaComp;
                }
            }


            // recuperar la lista de todos los objetos de la clase paper desde la BD
            //Asi tenemos los articulos
            List<Paper> papers = dal.GetAll<Paper>().ToList();
            Paper paper1 = null;
            //Busca el paper introducido en la lista de  papers . Si esta se devuelve en paper 1 sino se devuelve null
            //Recorre cada elemento de la lista papers
            foreach (var paperComp in papers)
            {   //si coincide con el paper de entrada
                if (paperComp.Title == paper)
                {
                    paper1 = paperComp;
                }
            }

            // elimina el articulo de la lista Evaluation Pending 
            area1.RemoveEvalPeningPaper(paper1);
            //añade el articulo en la lista publication Pending
            area1.addPubliPeningPaper(paper1);



            dal.Commit();


        }

        // List<Paper> ListaPending = area.getPublicationPendifsetng();

        ////METODO PARA MOVER DESDE PUBLICATION A EVALUATION
        public void MoverPublicationAEvaluation(string area, string paper)
        {
            // recuperar la lista de todos los objetos de la clase Area desde la BD
            List<Area> areas = dal.GetAll<Area>().ToList();
            Area area2 = null;

            //Busca el area introducido en la lista de  areas . Si esta se devuelve en area 1 sino se devuelve null
            foreach (var areaComp in areas)
            {
                if (areaComp.Name == area)
                {
                    area2 = areaComp;
                }
            }
            // recuperar la lista de todos los objetos de la clase paper desde la BD
            //Asi tenemos los articulos
            List<Paper> papers = dal.GetAll<Paper>().ToList();
            Paper paper2 = null;
            //Busca el paper introducido en la lista de  papers . Si esta se devuelve en paper 1 sino se devuelve null
            //Recorre cada elemento de la lista papers
            foreach (var paperComp in papers)
            {   //si coincide con el paper de entrada
                if (paperComp.Title == paper)
                {
                    paper2 = paperComp;
                }
            }
            // añade el articulo de la lista Evaluation Pending 

            area2.addEvalPeningPaper(paper2);
            //paper2.setEvaluationPendingArea(area2);

            //elimina el articulo en la lista publication Pending
            area2.RemovePubliPeningPaper(paper2);
            //paper2.removePublicationPendingArea(area2);


            dal.Commit();


        }
        //Devolver todos los articulos que estan en Publication Pendiendo con un area de parametro de entrada
        public List<Paper> SelectPublicationP(String area)
        {
            //cogemoa todos los articulos de la base de datos
            List<Paper> Allpapers = dal.GetAll<Paper>().ToList();
            List<Paper> paperList = new List<Paper>();
            //Recuperamos todas las areas de la BD
            List<Area> areas = dal.GetAll<Area>().ToList();
            Area area3 = null;

            //Buscamos el area de entrada en las areas que tenemos 
            foreach (var a in areas)
            {
                if (a.Name == area)
                {
                    area3 = a;
                }
            }
            //recorre todos los articulos de la clase paper
            foreach (Paper p in Allpapers)
            {   // todos los articulos de la lista Publication Pending que tengan esa area se añade a la lista
                try
                {                    
                    if (p.PublicationPendingArea?.Name == area3.Name) 
                    {
                        paperList.Add(p);

                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("El area introducido no existe");
                }

            }
            return paperList;

        }

        //public List<Paper> SeleccionarPublicar(string area)
        //{

        //    List<Paper> paperList = new List<Paper>();
        //    List<Area> areas = dal.GetAll<Area>().ToList();
        //    Area area3 = null;

        //    foreach (var a in areas)
        //    {
        //        if (a.Name == area)
        //        {
        //            area3 = a;
        //        }
        //    }
        //    paperList.AddRange(area3.getPublicationPending());

        //    return paperList;
        //}


        //Hacemos lo mismo para obtener la lista de Evaluation Pending
        public List<Paper> SelectEvaluationP(String area)
        {
            //cogemoa todos los articulos de la base de datos
            List<Paper> Allpapers = dal.GetAll<Paper>().ToList();
            List<Paper> paperList = new List<Paper>();
            //Recuperamos todas las areas de la BD
            List<Area> areas = dal.GetAll<Area>().ToList();
            Area area4 = null;

            //Buscamos el area de entrada en las areas que tenemos 
            foreach (var a in areas)
            {
                if (a.Name == area)
                {
                    area4 = a;
                }
            }
            //recorre todos los articulos de la clase paper
            foreach (Paper p in Allpapers)
            {   // todos los articulos de la lista Evaluation Pending que tengan esa area se añade a la lista
                try
                {
                    if (p.EvaluationPendingArea?.Name == area4.Name)
                    {
                        paperList.Add(p);
                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("El area introducido no existe");
                }


            }
            return paperList;

        }



        //public List<Paper> SeleccionarEvaluar(string area)
        //{
        //    List<Paper> paperList = new List<Paper>();
        //    List<Area> areas = dal.GetAll<Area>().ToList();
        //    Area area3 = null;
        //    //Buscamos el area de entrada en las areas que tenemos 
        //    foreach (var a in areas)
        //    {
        //        if (a.Name == area)
        //        {
        //            area3 = a;
        //        }
        //    }
        //    paperList.AddRange(area3.getEvaluationPending());

        //    return paperList;
        //}

        ////METODO PARA AÑADIR FECHA 
        public void setFecha(DateTime fecha, string issue)
        {
            List<Issue> ListIssues = dal.GetAll<Issue>().ToList();
            Issue issueSeleccionado = null;
            foreach (var iss in ListIssues)
            {
                if (iss.Number.ToString() == issue)
                {
                    issueSeleccionado = iss;
                }
            }
            issueSeleccionado.PublicationDate = fecha;
        }


        //enviar articulo

        public void enviarPaper(String area, String titulo, List<Person> ListaIdCoAutores)
        {

            // String AutorPaper = UsuarioIniciado.Name + ", " + UsuarioIniciado.Surname + "." + CoAutores; //juntamos el autor y los coautores
            Area areaX = dal.GetWhere<Area>(x => x.Name == area).First(); //asignamos area
            Paper paperN = new Paper(titulo, DateTime.Now, areaX, UsuarioIniciado); //creamos paper
            paperN.setCoAuthorsList(ListaIdCoAutores);
            AddPaper(paperN); //insertamos paper


            dal.Commit(); //actualizamos BD



        }

        public bool ExisteAutor(String nombre, String apellido)
        {
            if (dal.GetWhere<Person>(x => x.Name == nombre).Any())
            {
                Person persona = dal.GetWhere<Person>(x => x.Name == nombre).First();
                if (persona.Surname == apellido)
                {
                    return true;
                }
                else { return false; }
            }
            else return false;
        }

        public bool existePaper(String titulo)
        {
            if (dal.GetWhere<Paper>(x => x.Title == titulo).Any())
            {
                return true;
            }
            else return false;
        }





        // public void introducirCoAutor(List<Person> coAuthors )
        //{
        //Paper articulo = dal.GetAll<Paper>().Last();
        //if (coAuthors.Count() <= 4) //comprobamos que tiene <=4 coAutores
        //{    //inicializacmos las variables a usar
        //    bool check = true;


        //    foreach (Person P in coAuthors)//comprobamos que existan todos los coAutores en la BD
        //    {
        //        if (!dal.GetWhere<Person>(x => x.Name == P.Name).Any())
        //        {//comprobamos personas con el mismo nombre
        //            check = false;
        //            break;
        //        }
        //        else if (!dal.GetWhere<Person>(x => x.Surname == P.Surname).Any())
        //        {//comprobamos personas con el mismo apellido
        //            check = false;
        //            break;
        //        }
        //    }

        //    if (check)
        //    {//si todos los coAutores existen en la BD
        //        //Paper paper = dal.GetWhere<Paper>(x => x.Id == idpaper).First();//obtenemos el paper de mismo título
        //        //paper.setCoAuthorsList(coAuthors);//le añadimos al paper los coAutores (con el método creado en Paper)
        //    }
        //    else throw new ServiceException("Alguno de los coAutores insertados no existe en la base de datos");


        //}
        //else throw new ServiceException("El maximo de coAutores es de 4");
        // }


        public List<Paper> MostrarPendEvaluar()
        {//recupero el area del usuario iniciado, de donde recuperamos la lista de pend de evaluar
            Area areaE = UsuarioIniciado.getAreaEditor();
            return areaE.getEvaluationPending(); //devuelve la lista pendiente de evaluar con el metodo hecho en Area
        }
        public List<Paper> MostrarPendEvaluarArea(string name)
        {//recupero el area del usuario iniciado, de donde recuperamos la lista de pend de evaluar
            Area area = dal.GetWhere<Area>(x => x.Name == name).First();
            return area.getEvaluationPending(); //devuelve la lista pendiente de evaluar con el metodo hecho en Area
        }


        public void EvaluarArticulo(int idPaper, string comments, Boolean resultado)
        {//elegir uno de los articulos y evaluarlo
            Evaluation evaluation = new Evaluation(resultado, comments, DateTime.Today); //creamos una evaluacion
            Paper paper = dal.GetWhere<Paper>(x => x.Id == idPaper).First(); //obtenemos el paper de la BD
            paper.setEvaliation(evaluation);//insertamos la evaluacion en el paper

            Area areaE = UsuarioIniciado.getAreaEditor(); //recuperamos area del usuario iniciado
            List<Paper> ListaE = areaE.getEvaluationPending(); //obtenemos la lista de pendientes de evaluar
            List<Paper> ListaP = areaE.getPublicationPending(); //obtenemos en la lista pendientes de publicar
            if (resultado)
            { //Si resultado TRUE añadimos en lista PublicationPending el paper
                ListaP.Add(paper);
            }
            ListaE.Remove(paper); //Se cumpla o no tenemos que eliminar el paper de la lista EvaluationPending

            dal.Commit();
        }




        //Listado con todos los articulos y su estado

        //devolvemos todos los articulos de PubPending y EvalPending con un atributo a la derecha que dependiendo de que lista se haya sacado es estad:PendEval o PendPub
        //hay q ir una a una, areas, para sacar sus papers

        //Obtener el id del artículo
        public int idArticuloPasado(String tituloArticuloPasado)
        {
            Paper p = dal.GetWhere<Paper>(x => x.Title == tituloArticuloPasado).First();
            return p.Id;
        }
        public bool existeArticuloAMostrar(String tituloArticuloDado)
        {
            if (dal.GetWhere<Paper>(x => x.Title == tituloArticuloDado).Any())
            {
                return true;
            }
            return false;
        }
        public String TítuloDeArticulo(int id) //método para devolver el título de un artículo
        {
            Paper p = dal.GetWhere<Paper>(x => x.Id == id).First(); //creamos un paper P del mismo id 
            String s = p.Title; //conseguimos el titulo
            return s;
        }

        public String AutoresDelArticulo(int id)
        {
            Paper p = dal.GetWhere<Paper>(x => x.Id == id).First();
            List<String> listaNombres = new List<string>();//creo una lista con el autor del articulo

            //String IdAutor = p.Responsible.Id;
            //Person autor = dal.GetWhere<Person>(x => x.Id == IdAutor).First();  Intentos fallidos
            //listaNombres.Add(autor.Name);

            //añadimos nombre y apellidos del autor en el formato (Nombre, Apellido.)
            listaNombres.Add(p.Responsible.Name);
            listaNombres.Add(", ");
            listaNombres.Add(p.Responsible.Surname);
            listaNombres.Add(".");

            List<Person> AuthorsList = p.CoAuthors.ToList();//saco lista de coautores
            foreach (Person per in AuthorsList)
            { //añadimos nombre y apellidos de los coautores en el formato (, Nombre, Apellido.)
                listaNombres.Add(", ");
                listaNombres.Add(per.Name);
                listaNombres.Add(", ");
                listaNombres.Add(per.Surname);
                listaNombres.Add(".");
            }
            String s = String.Join("", listaNombres);
            return s;
        }


        public String EstadoDelArtículo(int id) // "Pendiente de evaluación" , "Pendiente de publicación" , "Publicado" , "Rechazado"
        { //tres ifs anidados, que compruebe o bien si esta en pendiente de evaluar, o si está en pendiente de publicar o si está en issue
            Paper p = dal.GetWhere<Paper>(x => x.Id == id).First(); //sacamos el articulo
            Area A = p.BelongingArea; //sacamos el área del articulo
            List<Paper> listaArtPendEvaluar = A.getEvaluationPending(); //lista de pendientes de evaluar de ese área
            List<Paper> listaArtPendPublicar = A.getPublicationPending(); //lista de pendientes de publicar de ese área

            //ahora tenemos que sacar la lista de publicadas de Issue
            List<Issue> ListaIssues = UsuarioIniciado.getMagazineEditor().getListaIssues();
            List<Paper> listaArtPublicados = new List<Paper>();
            foreach (Issue I in ListaIssues)
            {
                List<Paper> listaPapersPorIssue = I.getListaPapers();// la lista de papers de cada Issue
                foreach (Paper P in listaPapersPorIssue) //añadimos los papers de cada Issue a la listaArtPublicados UNO A UNO
                {
                    listaArtPublicados.Add(P);
                }
            }

            if (listaArtPendEvaluar.Contains(p)) //está en pendiente de evaluar?
            {
                return "Pendiente de evaluación";
            }
            else if (listaArtPendPublicar.Contains(p)) //está en pendiente de publicar?
            {
                return "Pendiente de publicación";
            }
            else if (listaArtPublicados.Contains(p)) //está en publicado?
            {
                return "Publicado";
            }
            else return "Rechazado";

        }
        public List<Paper> TodosArtículosConEstado()
        {
            List<Paper> listaPapersEstado = new List<Paper>();//creamos la lista de papers

            List<Area> ListaAreas = UsuarioIniciado.getMagazineEditor().getListaAreas(); //Conseguimos la lista de areas de la magazine del usuarioIniciado

            foreach (Area A in ListaAreas)
            { //recorrer la lista de areas, en cada iteración sacar los papers de ese área
                List<Paper> listaAreaA = A.getListPapers();// la lista de papers
                foreach (Paper P in listaAreaA) //añadimos los papers de la listaAreaA a la listaPapersEstado UNO A UNO
                {
                    listaPapersEstado.Add(P);
                }
            }
            return listaPapersEstado;
        }

        //métodos para el caso de uso CONSUTLAR CONTENIDO EJEMPLARES PUBLICADOS
        public List<Paper> TodosArticulosDelEjemplar(int Num)
        {
            Issue Is = dal.GetWhere<Issue>(x => x.Number == Num).First();
            return Is.getListaPapers();
        }
        public float PrecioEjemplar(int NumEj)
        {
            Issue Is = dal.GetWhere<Issue>(x => x.Number == NumEj).First();
            return Is.Price;
        }
        public bool existeEjemplar(int Num)
        {
            if (dal.GetWhere<Issue>(x => x.Number == Num).Any())
            {
                return true;
            }
            return false;
        }

        //métodos para COMPRAR EJEMPLARES
        public List<Issue> GetIssues()
        {
            Magazine.Entities.Magazine magazine = dal.GetAll<Magazine.Entities.Magazine>().First();//obtenemos la magazine en cuestión
            return magazine.getListaIssues();//obtenemos la lista de ejemplares de la magazine
        }

        public String NumeroDelEjemplar(int numIssue)
        {
            return numIssue.ToString();
        }

        public float PrecioDelEjemplar(int numIssue)
        {
            Issue I = dal.GetWhere<Issue>(x => x.Number == numIssue).First();
            return I.Price;
        }

        public float DescuentoDelEjemplar(int numIssue)
        {
            Issue I = dal.GetWhere<Issue>(x => x.Number == numIssue).First();
            return I.Discount;
        }
        public bool tieneDescuento()
        { //comprobamos q tenga descuento el usuario(en caso de estar suscrito
            if (UsuarioIniciado.MagazineSuscriber == true) { return true; } else { return false; }
        }

        //public float CalcularPrecioTotal()
        //{
        //    Issue I = dal.GetWhere<Issue>(x => x.Number == numIssue).First();
        //    if (UsuarioIniciado.MagazineSuscriber == true)
        //    {
        //        return I.Discount;
        //    }
        //    else { return 0; }
        //}


        //crear nuevo issue 


        public void AddIssueM(int number, float price, float discount, string p, DateTime date, string area)
        {

            List<Magazine.Entities.Magazine> magazines = dal.GetAll<Magazine.Entities.Magazine>().ToList();
            Magazine.Entities.Magazine mag = magazines.First();
            Issue issuePublicar = new Issue(number, mag, price, discount, date);

            List<Paper> Papers = dal.GetAll<Paper>().ToList();
            Paper paper = null;

            //Buscamos el paper de entrada en las papers que tenemos 
            foreach (var paperCheck in Papers)
            {
                if (paperCheck.Title == p)
                {
                    paper = paperCheck;
                }
            }
            // añadisimos el paper en la lista de published paper
            issuePublicar.addPublishedPapers(paper);
            //creamos el issue 
            mag.addIssues(issuePublicar);

            List<Area> areas = dal.GetAll<Area>().ToList();
            Area area2 = null;

            //Busca el area introducido en la lista de  areas . Si esta se devuelve en area 1 sino se devuelve null
            foreach (var areaComp in areas)
            {
                if (areaComp.Name == area)
                {
                    area2 = areaComp;
                }
            }

            
            area2.RemovePubliPeningPaper(paper);

            dal.Commit();
        }

        public void AddEvaluationP(string p, Boolean accepted, string comments, DateTime date) {
            Paper paper = null;
            List<Paper> Papers = dal.GetAll<Paper>().ToList();
            //Buscamos el paper de entrada en las papers que tenemos 
            foreach (var paperCheck in Papers)
            {
                if (paperCheck.Title == p)
                {   // tenemos el objeto paper 
                    paper = paperCheck;
                }
            }
            //creamos la evaluacion 
            Evaluation ev = new Evaluation(accepted,comments,date);
            paper.setEvaliation(ev);
            dal.Commit();
        }

        public void DeletePaperFromEP(string p) {
            Paper paper = null;
            List<Paper> Papers = dal.GetAll<Paper>().ToList();
            //Buscamos el paper de entrada en las papers que tenemos 
            foreach (var paperCheck in Papers)
            {
                if (paperCheck.Title == p)
                {   // tenemos el objeto paper 
                    paper = paperCheck;
                }
            }
            //Metodo para obtener el area del paper
            Area areaPaper =paper.AreaPaper();

            areaPaper.RemoveEvalPeningPaper(paper);
            dal.Commit();
        }
    }
}

