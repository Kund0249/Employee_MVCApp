using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.DataAccess.Repository
{
    public class UserRepository
    {
        
        private readonly DataContext context;
        public UserRepository()
        {
            
            context = new DataContext();
        }

        public void Add(UserEntity user)
        {
            //code
            context.user.Add(user);
            context.SaveChanges();
        }
    }
}
