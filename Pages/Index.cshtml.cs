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
            var service = HttpContext.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment;

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
            //Obtengo el directorio
            string folderName = "json/";
            string webRootPath = service.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            
            //Escribo en disco
            System.IO.File.WriteAllText(newPath + @"/person_" + dni + ".json", objeto);

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


