using ChetuCoreWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChetuCoreWebApi.contract
{
    public class LoginResult
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public User Data { get; set; }
        public string Token { get; set; }
    }
}
