using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using survey.Models;
using Newtonsoft.Json;
using System.IO;
using QRCoder;
using System.Drawing;

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
            //System.IO.File.WriteAllText("/json/person_" + dni + ".json", objeto);
            
            //Genero el QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Guardo la imagen
            qrsourcefile = "/images/person_" + dni + ".png";
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


