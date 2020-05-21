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
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            qrsourcefile = "";
        }

        public void OnPost()
        {
            nombre = Request.Form[nameof(nombre)];
            dni = Request.Form[nameof(dni)];
            fiebre = Request.Form[nameof(fiebre)];
            tos = Request.Form[nameof(tos)];

            surveyform sr = new surveyform();
            sr.nombre = nombre.ToUpper();
            sr.dni = dni.ToUpper();
            sr.fiebre = false; 
            sr.tos = false;

            //Serializo el objeto
            string objeto = JsonConvert.SerializeObject(sr);
            //Escribo en disco
            System.IO.File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), @"json/person_" + dni + ".json"), objeto);

            // Guardo la imagen
            qrsourcefile = "https://api.qrserver.com/v1/create-qr-code/?data=https://usurvey.azurewebsites.net/About?id="+ dni +"&amp;size=100x100" ;
        }

        public string nombre
        {
            get;
            set;
        }

        public string dni
        {
            get;
            set;
        }

        public string fiebre
        {
            get;
            set;
        }

        public string tos
        {
            get;
            set;
        }

        public string qrsourcefile
        {
            get;
            set;
        } 
    }
}


