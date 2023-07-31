using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CodeGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeGeneratorController : Controller
    {
    
        [HttpGet]
        public string GetCode()
        {
           return GenerateUniqueCode();
            
        }

        public static string GenerateUniqueCode()
        {
            Random ran = new Random(DateTime.Now.Millisecond);
            const string chars = "ACDEFGHKLMNPRTXYZ234579";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[ran.Next(s.Length)]).ToArray());
        }
    }
}
   

