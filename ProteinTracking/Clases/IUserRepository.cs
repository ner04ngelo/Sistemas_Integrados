using ProteinTracking.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProteinTracking
{
    interface IUserRepository
    {
        void Add(User user);

        IReadOnlyCollection<User> GetAll();

        User GetById(int id);

        void Save(User updateUser);
    }
}
