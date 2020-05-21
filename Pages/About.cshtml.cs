using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using survey.Models;
using Newtonsoft.Json;
using System.IO;

namespace survey.Pages
{
    public class ComprobarModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string id = Request.Query["id"];
            if(id!=null)
            {
                Message = "id = " + id;

                
            }
            else
                Message = "No se encontro la declaracion para el usuario, o el codigo de seguridad es incorrecto.";
        }

    }
}
