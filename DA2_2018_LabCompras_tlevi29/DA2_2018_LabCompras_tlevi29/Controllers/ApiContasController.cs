using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DA2_2018_LabCompras_tlevi29.Models;

namespace DA2_2018_LabCompras_tlevi29.Controllers
{
    [Route("api/[controller]")]
    public class ApiContasController : Controller
    {
        [HttpGet]
        public List<Conta> Get()
        {
            return Repository.Contas;
        }

        // GET: api/ApiServer/5
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            Conta d = Repository.GetContas(name);
            if (d != null)
                return Ok(d);
            else
                return NotFound();
        }

        // POST: api/ApiServer
        [HttpPost]
        public void Post([FromBody]Conta contas)
        {
            Repository.AddConta(contas);
        }

    }
}
