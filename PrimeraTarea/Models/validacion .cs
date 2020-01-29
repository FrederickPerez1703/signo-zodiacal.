using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraTarea.Models
{
    public class validacion
    {
        [Required(ErrorMessage ="Este campo no puede estar vacion")]
        public int dia {get ; set;}

        [Required(ErrorMessage = "Este campo no puede estar vacion")]
        public int mes { get; set; }
 
    }
}
