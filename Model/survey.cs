using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class surveyform
    {
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

        public string temperatura { get; set; }
    }
}