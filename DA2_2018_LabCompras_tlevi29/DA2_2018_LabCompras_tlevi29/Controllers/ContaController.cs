﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2018_LabCompras_tlevi29.Models;

namespace DA2_2018_LabCompras_tlevi29.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            List<Conta> contas = Repository.Contas;
            return View(contas);
        }

        [HttpGet]
        public IActionResult NovaConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaConta(Conta c)
        {
            if (ModelState.IsValid)
            {
                Repository.AddConta(c);
                return View("ContaConfirmada", c);
            }
            else
                return View();
        }

        public IActionResult ContaConfirmada()
        {
            return View();
        }

        public IActionResult LimparContas()
        {
            Repository.ClearContas();
            return View ("Index", Repository.Contas);
        }



    }
}