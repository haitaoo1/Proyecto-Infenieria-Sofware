using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;


namespace Magazine.Services
{
    public interface IMagazineService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddPerson(Person p);
        void AddMagazine(Magazine.Entities.Magazine m);
        void AddArea(Area a);

        // A partir de aquí cread los vuestros
        void AddUser(User u);

        User IniciarSesion(string login, string password);

        bool esChiefEditor();
        bool esEditorArea();
        bool esUsuario();

        // A partir de aquí cread los vuestros
        // void AddUser(User u);
        void RegistrarUsuario(string id, string nombre, string apellidos, string email, string areasDeInteres, string login, string password, bool alerta);
        List<Paper> MostrarPendEvaluarArea(string name);
        Area comprabarArea(string area);
        bool existeArea(string area);
        bool ExisteAutor(String nombre, String apellido);
        bool existeEjemplar(int Num);
        List<Paper> TodosArticulosDelEjemplar(int Num);
        float PrecioEjemplar(int NumEj);
        void enviarPaper(String area, String titulo, List<Person> ListaIdCoAutores);
        bool existePaper(String titulo);
        String TítuloDeArticulo(int id);
        String AutoresDelArticulo(int id);
        List<Paper> TodosArtículosConEstado();
        String EstadoDelArtículo(int id);
        int idArticuloPasado(String tituloArticuloPasado);
        bool existeArticuloAMostrar(String tituloArticuloDado);

        //Compra CU
        List<Issue> GetIssues();
        String NumeroDelEjemplar(int numIssue);
        float PrecioDelEjemplar(int numIssue);
        float DescuentoDelEjemplar(int numIssue);
        bool tieneDescuento();


        void MoverEvaluationAPublication(string area, string paper);
        void MoverPublicationAEvaluation(string area, string paper);
        List<Paper> SelectPublicationP(String area);
        List<Paper> SelectEvaluationP(String area);
        void setFecha(DateTime fecha, string issue);
        List<Area> AllAreas();
        void AddIssue(Issue Issues);
        void AddIssueM(int number, float price, float discount, string p, DateTime date, string area);
        void AddEvaluationP(string p, Boolean accepted, string comments, DateTime date);
        void DeletePaperFromEP(string p);
        //List<Paper> SeleccionarPublicar(String area);
        //List<Paper> SeleccionarEvaluar(string area);
    }
}
