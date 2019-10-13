using RegistroProteinas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace RegistroProteinas
{
    /// <summary>
    /// Descripción breve de RegistroProteinasServices
    /// </summary>
    [WebService(Namespace = "http://simpleprogrammer.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [ServiceContract(Namespace = "http://simpleprogrammer.com/")]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public interface IRegistroProteinasService
    {
        [WebMethod]
        [OperationContract]
        int AddProtein(int amount, int userId);

        [WebMethod]
        [OperationContract]

        int AddUser(string name, int goal);

        [WebMethod]
        [OperationContract]

        List<User> listUsers();
    }
          

    public class RegistroProteinasServices : WebService, IRegistroProteinasService
    {
        private System.ComponentModel.IContainer components;
        private UserRepository repository = new UserRepository();

        [WebMethod (Description = "Incrementa un monto al total acumulado")]
        public int AddProtein(int amount, int userId)
        {
            var user = repository.GetById(userId);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);
            return user.Total;
        }


        [WebMethod(Description = "Agrega un nuevo usuario")]

        public int AddUser(string name, int goal)
        {
            var user = new User { Goal = goal, Name = name, Total = 0 };
            repository.Add(user);
            return user.UserId;
        }

        [WebMethod]
        public List<User> listUsers()
        {
            return new List<User>(repository.GetAll());

        }

        private void InitializeComponent()
        {

        }
    }
}
