using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class OlaController : Controller
    {
        // GET: Ola
        public string Index()
        {
            return "Olá MVC5";
        }

        public string Teste()
        {
            return "Teste feito <b>texto negrito como da video aula!</b>";
        }

        public JsonResult GetJson()
        {
            var produto = new
            {
                ID = 12,
                Nome= "Bike",
                Qtde= 10
            };
            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        public string GetDados(string nome, int idade =20)
        {
            return HttpUtility.HtmlEncode( string.Format("BemVido {0} com idade{1}", nome, idade));
        }
    }
}