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
            dni=""; // Set para que la vista lo interprete ok

            string id = Request.Query["id"];
            if(id!=null)
            {
                Message = "Usuario DNI " + id;

                //Obtengo el directorio para el archivo json
                var service = HttpContext.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment;
                string folderName = "json/";
                string webRootPath = service.WebRootPath;
                string Path = System.IO.Path.Combine(webRootPath, folderName);

                // Cargo el json en la entidad
                surveyform sf = JsonConvert.DeserializeObject<surveyform>(System.IO.File.ReadAllText(Path + @"/person_" + id + ".json"));
                nombre = sf.nombre;
                dni = sf.dni;
                nombre = sf.nombre;
                dni = sf.dni;
                fiebre = sf.fiebre; 
                tos = sf.tos;
                garganta = sf.garganta;
                olfato = sf.olfato;
                respirar = sf.respirar;
                diarrea = sf.diarrea;
                vomito = sf.vomito;
                erupciones = sf.erupciones;
                cabeza = sf.cabeza;
                muscular = sf.muscular;
                sangrado = sf.sangrado;
                piel = sf.piel;
                contacto = sf.contacto;
                contacto_desc = sf.contacto_desc;
                test = sf.test;
                test_desc = sf.test_desc;
                fecha_test = sf.fecha_test;

            }
            else
                Message = "No se encontro la declaracion para el usuario, o el codigo de seguridad es incorrecto.";
        }

        public void OnPost()
        {
            dni=""; 

            string id = Request.Query["id"];
            temperatura = Request.Form[nameof(temperatura)];

            var service = HttpContext.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment;
            string folderName = "json/";
            string webRootPath = service.WebRootPath;
            string Path = System.IO.Path.Combine(webRootPath, folderName);

            // Cargo el json en la entidad
            surveyform sf = JsonConvert.DeserializeObject<surveyform>(System.IO.File.ReadAllText(Path + @"/person_" + id + ".json"));
            sf.temperatura = temperatura;

            //Serializo el objeto a json
            string objeto = JsonConvert.SerializeObject(sf);

            //Escribo en disco el archivo
            System.IO.File.WriteAllText(Path + @"/person_" + sf.dni + ".json", objeto);
        }

        public string nombre { get; set; }
        public string dni { get; set; }
        public string fiebre { get; set; }
        public string tos { get; set; }
        public string garganta { get; set; }
        public string olfato { get; set; }
        public string respirar { get; set; }
        public string diarrea { get; set; }
        public string vomito { get; set; }
        public string erupciones { get; set; }
        public string cabeza { get; set; }
        public string muscular { get; set; }
        public string sangrado { get; set; }
        public string piel { get; set; }
        public string contacto { get; set; }
        public string contacto_desc { get; set; }
        public string test { get; set; }
        public string fecha_test { get; set; }
        public string test_desc { get; set; }

        public string temperatura {get;set;}


    }
}
