using Employee_MVCApp.DataAccess.Entity;
using Employee_MVCApp.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.Processing
{
    public class UserManager
    {
        private readonly UserRepository repository = new UserRepository();
        public void Add(UserEntity user)
        {
            try
            {
                repository.Add(user);
            }
            catch (Exception ex)
            {

                //log
            }
        }
    }
}
