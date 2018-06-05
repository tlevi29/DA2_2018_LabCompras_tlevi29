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
    public class ApiDespesasController : Controller
    {
        // GET: api/ApiServer
        [HttpGet]
        public List<Despesa> Get()
        {
            return Repository.Despesa;
        }

        // GET: api/ApiServer/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Despesa d = Repository.GetDespesas(id);
            if (d != null)
                return Ok(d); //return new ObjectResult(d);
            else
                return NotFound();
        }
        
        // POST: api/ApiServer
        [HttpPost]
        public void Post([FromBody]Despesa despesas)
        {
            Repository.AddDespesa(despesas);
        }
    }
}
