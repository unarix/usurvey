using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class surveyform
    {
        public string nombre { get; set; }
        public string dni { get; set; }
        public bool tos { get; set; }
        public bool fiebre { get; set; }
    }
}