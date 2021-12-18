using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_NETCore_Web_API_Authentication_Using_JWT
{
    public interface IJwtAuth
    {
        string Authentication(string username, string password);
    }
}
