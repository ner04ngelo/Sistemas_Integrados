using HelloWorldWebService.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HelloWorldWebService
{
    /// <summary>
    /// Descripción breve de RegistroProteinasServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistroProteinasServices : System.Web.Services.WebService
    {

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
    }
}
