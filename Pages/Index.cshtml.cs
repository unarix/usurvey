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
using System.Drawing.Imaging;

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
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("este es un texto de ejemplo", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            string test = "xxx";

            using(var image = qrCodeImage)
            {
                var resized = new Bitmap(200, 200);
                using (var graphics = Graphics.FromImage(resized))
                {
                    graphics.DrawImage(image, 0, 0, 200, 200);
                    //string filename = Path.Combine(Directory.GetCurrentDirectory(), @"images/person_" + dni + ".png");
                    //resized.Save(filename, ImageFormat.Png);
                }       
            } 

            // Guardo la imagen
            qrsourcefile = "/images/person_" + dni + ".png";
        }

        private static Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
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


