using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CadernoDecoraFestas.Models;
using WebMatrix.WebData;

namespace CadernoDecoraFestas.Controllers
{
    public class FornecedorController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }


        //Carga inicial. Criar action para criação
        public void IniciaRegras()
        {
            try
            {
                Roles.CreateRole("fornecedor"); Roles.CreateRole("admin");
                WebSecurity.CreateUserAndAccount("admin", "admin");
                Roles.AddUserToRole("admin", "admin");
            }
            catch { }
        }

        public ActionResult Create()
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            return View();
        }


        [HttpPost]
        public ActionResult Create(Fornecedor fornecedor)
        {
            IniciaRegras();
            if (ModelState.IsValid)
            {
                WebSecurity.CreateUserAndAccount(fornecedor.Login, fornecedor.Senha);
                Roles.AddUserToRole(fornecedor.Login, "fornecedor");

                TempData[" Mensagem "] = "Cadastro realizado";
                unitOfWork.FornecedorRepository.Adiciona(fornecedor);
                //unitOfWork.Salva();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        //[HttpPost]
        [Authorize(Roles = "fornecedor")]
        public ActionResult Edit()
        {
            //Fornecedor fornecedor = unitOfWork.FornecedorRepository.Busca(id);
            //return View(fornecedor);
            if (User.Identity.IsAuthenticated)
            {
                Fornecedor fornecedor = unitOfWork.FornecedorRepository.LocalizaNome(User.Identity.Name);
                return View(fornecedor);
            }
            return null;
        }

        [HttpPost]
        [ActionName("Edit")]
        [Authorize(Roles = "fornecedor")]
        public ActionResult EditConfimed(Fornecedor fornecedor)
        {
            Fornecedor fornecedorOld = unitOfWork.FornecedorRepository.LocalizaNome(User.Identity.Name);

            fornecedor.Login = fornecedorOld.Login;//por mais que o usuário consiga trocar o login não afetará o objeto
            unitOfWork.FornecedorRepository.Edita(fornecedor);
            return RedirectToAction("Edit");
        }


        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            Fornecedor fornecedor = unitOfWork.FornecedorRepository.Busca(id);
            return View(fornecedor);
        }

        [HttpPost]
        [ActionName("Delete")]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            unitOfWork.FornecedorRepository.Remove(id);
            //unitOfWork.Salva();
            return RedirectToAction("Index");
        }


        //
        // GET: /Fornecedor/
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(unitOfWork.FornecedorRepository.Fornecedores);
        }


        public ActionResult Login()
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Fornecedor fornecedor, string returnUrl)
        {

            if (unitOfWork.FornecedorRepository.LocalizaLoginSenha(fornecedor) != null)
            {
                FormsAuthentication.SetAuthCookie(unitOfWork.FornecedorRepository.LocalizaLoginSenha(fornecedor).Nome, false); //segundo parâmetro é um booleano relativo ao tipo do cookie, se é permanente ou não

                User.IsInRole("fornecedor");
                return RedirectToAction("Edit", "Fornecedor");
            }
            if (fornecedor.Login == "admin" && fornecedor.Senha == "admin")
            {

                FormsAuthentication.SetAuthCookie("admin", false); //segundo parâmetro é um booleano relativo ao tipo do cookie, se é permanente ou não 

                User.IsInRole("admin");
                return RedirectToAction("Index", "Fornecedor");
            }
            else
            {
                ModelState.AddModelError("", "O usuário e/ou a senha está incorreto .");
            }

            return View();
        }





        //[HttpPost]
        //public ActionResult Login(LoginModel model, string returnUrl)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        if(Membership.ValidateUser(model.Email, model.Password))
        //        {
        //            FormsAuthentication.SetAuthCookie(model.Email, model.RememberMe);
        //            if ( Url.IsLocalUrl( returnUrl ) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && ! returnUrl.StartsWith("//") && ! returnUrl.StartsWith(" /\\ "))
        //            {
        //                return Redirect ( returnUrl );
        //            }
        //            else
        //            {
        //                return RedirectToAction (" Index ", " Fornecedor");
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "O usuário e/ou a senha está incorreto .");
        //        }
        //    }

        //    return View(model);
        //}


    }
}
