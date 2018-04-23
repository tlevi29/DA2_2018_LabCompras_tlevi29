﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2018_LabCompras_tlevi29.Models;

namespace DA2_2018_LabCompras_tlevi29.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Despesa()
        {
            List<Despesa> despesas = Repository.Despesa;
            return View();
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
                Repository.AddDespesa(d);
                return View("DespesaConfirmada", d);
            }
            else
                return View();
        }

        public IActionResult DespesaConfirmada()
        {
            return View();
        }


    }
}