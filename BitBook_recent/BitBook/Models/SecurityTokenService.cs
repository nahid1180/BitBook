using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{

    public interface IBitSecurityTokenService
    {
        Guid GetSecurityToken(Guid id);
        int GetActualId(Guid id);
    }

    public class SecurityTokenService
    {
        
    }
}