using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC5.Controllers
{
    public class NovasRotasController : Controller
    {
        // GET: NovasRotas
        public string  Index(DateTime nascimento)
        {
            return string.Format("Data de {0:dd/MM/yyyy}",nascimento); 
        }

        public string GetDados(string nome, int idade= 20)
        {

            return HttpUtility.HtmlEncode( string.Format("Bem vindo {0} com idade {1}", nome, idade));
        }

        public string GetPreco(int preco)
        {
            return "O preco" + preco;
        }

        public string Getclient(int id)
        {
            return "Codigo do cliente " + id;
        }
    }
}