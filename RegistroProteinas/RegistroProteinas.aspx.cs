using RegistroProteinas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroProteinas
{
    public partial class RegistroProteinas : System.Web.UI.Page
    {
       private static UserRepository repository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]

        public static int AgregarProteinas (int amount, int userId)
        {
            
            var user = repository.GetById(userId);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);
            return user.Total;
        }

        [WebMethod]

        public static int AgregarUsuario(string name, int goal)
        {
            var user = new User { Goal = goal, Name = name, Total = 0 };
            repository.Add(user);

            return user.UserId;
        }


        [WebMethod]

        public static List<User> ListUser()
        {
            return new List<User>(repository.GetAll());
        }
    }


    


}