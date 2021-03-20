using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_AEVO.Data;
using API_AEVO.Models;

namespace API_AEVO.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Valida"] = "";
            return View();
        }

        
        public IActionResult Editar(int Id, string Nome)
        {
            var model = new CidadeModel();
            model.Id = Id;
            model.Nome = Nome;
            ViewData["Valida"] = "";
            return View("index", model);
        }

        public IActionResult Excluir(int Id)
        {
            CidadeDB Cid = new CidadeDB();
            Cid.ExcluirDados(Id);
            return RedirectToAction("ListaCidade", "cidade");
        }

        public IActionResult Salvar(CidadeModel obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("index");
            }

            CidadeDB Cid = new CidadeDB();

            if (obj.Id == 0)
            {

                if (Cid.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cidade inserida com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Cidade!</div>";
                }
            }
            else
            {
                if (Cid.UpdateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cidade atualizada com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Cidade!</div>";
                }
            }

            return View("index");
        }

        public string Validar(CidadeModel obj)
        {

            CidadeDB Func = new CidadeDB();

            if (String.IsNullOrEmpty(obj.Nome))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome da Cidade!</div>";
            }

            if (Func.ValidarNome(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Cidade já cadastrada no banco!</div>";
            }

            return "";
        }
        
        [HttpGet]
        public IActionResult SearchCidade(string Texto)
        {
            CidadeDB Cid = new CidadeDB();
            var MLista = Cid.SearchCidade(Texto);
            return Json(new { success = (MLista.Count > 0) ? true : false, dados = MLista });            
        }


        public IActionResult ListaCidade()
        {
            CidadeDB Cid = new CidadeDB();
            var MLista = Cid.GetAll();
            return View(MLista);
        }

    }
}
