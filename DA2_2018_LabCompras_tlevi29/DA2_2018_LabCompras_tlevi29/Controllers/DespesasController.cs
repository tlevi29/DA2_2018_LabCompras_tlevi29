using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DA2_2018_LabCompras_tlevi29.Models;

namespace DA2_2018_LabCompras_tlevi29.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            List<Despesa> despesas = Repository.Despesa; /*Mostrar os dados guardados da lista*/
            return View (despesas); /*retornar na View o objeto "despesas"*/
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa d)
        {
            if (ModelState.IsValid)
            {
                Repository.AddDespesa(d); /*Guardar na lista os dados introduzido no formulário*/
                return View("DespesaConfirmada", d);
            }
            else
                return View();
        }

        public IActionResult DespesaConfirmada()
        {
            return View();
        }

        public IActionResult LimparDespesas()
        {
            Repository.ClearDespesas();
            return View("Index", Repository.Despesa);
        }
    }
}