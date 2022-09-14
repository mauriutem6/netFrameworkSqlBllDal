using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;
using inventarioapi.bll;
using inventarioapi.entidad;

namespace inventarioapi.Controllers
{
    public class wsController : Controller
    {
        // GET: ws
        inventariobll objeto_bll = new inventariobll();
        public string retorno1()
        {
            usuarioDTO modelo1 = new usuarioDTO();
            return JsonConvert.SerializeObject(new { mensaje = "", error = "0", data = "" });
        }

        [HttpGet]
        public string get_usuarios()
        {
            return objeto_bll.get_usuarios();
        }

    }
}