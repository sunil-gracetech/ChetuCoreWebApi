using ChetuCoreWebApi.contract.request;
using ChetuCoreWebApi.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChetuCoreWebApi.Services.v1
{
  public  interface IUser
    {
        User SignUp(User user);
        User SignIn(UserLogin user);
        string  ImageUpload(IFormFile file);

    }
}
