using ProteinTracking.Clases;
using System.Collections.Generic;
using System.Web.Http;


namespace ProteinTracking.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository repository = new UserRepository();


        public int Put(int id, [FromBody]int amount)
        {
            var user = repository.GetById(id);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);

            return user.Total;
        }

        public int Post([FromBody]CreateUserRequest request)
        {
            var user = new User { Goal = request.Goal, Name = request.Name, Total = 0 };
            repository.Add(user);

            return user.UserId;
        }


        public IEnumerable<User> Get()
        {
            return new List<User>(repository.GetAll());
        }


        public class CreateUserRequest
        {
            public string Name { get; set; }
            public int Goal { get; set; }
        }
    }
}