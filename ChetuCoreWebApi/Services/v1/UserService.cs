using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChetuCoreWebApi.contract.request;
using ChetuCoreWebApi.Model;
using Microsoft.AspNetCore.Http;

namespace ChetuCoreWebApi.Services.v1
{
    public class UserService : IUser
    {
        private EmployeeContext context;
        public UserService()
        {
            context = new EmployeeContext();
        }
        public string ImageUpload(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public User SignIn(UserLogin user)
        {
           if(context.Users.Any(e=>e.Email==user.Email && e.Password == user.Password)){
                var userdata = context.Users.SingleOrDefault(e => e.Email == user.Email && e.Password == user.Password);
                return userdata;

            }
            else
            {
                return null;
            }
        }

        public User SignUp(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
    }
}
