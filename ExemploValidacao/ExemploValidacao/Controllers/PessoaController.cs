using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploValidacao.Models;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            pessoa.Id = 0;

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }
        
        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
                {
                    "Cleyton",
                    "Anderson",
                    "Renata"
                };
            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValidarCpf(string cpf, int Id)
        {
           

            var retorno = (Id > 0);

            return Json(retorno, JsonRequestBehavior.AllowGet);
        }

    }
}