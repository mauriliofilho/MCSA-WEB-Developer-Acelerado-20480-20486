using LineOnCode.Store.UI.Infra;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
    [Route("teste")]
    //[GlobalExceptionFilter]
    public class TesteController : Controller
    {

        public string Ping() => "Pong";

        [HttpGet("erro")]
        public string Erro() => throw new Exception();

    }

    
}
