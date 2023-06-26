using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea5Aplicada.Shared;


public class Clientes
{
        [Key] 
        public int ClienteId {get; set;}
        [Required(ErrorMessage ="Los nombres son obligatorios")]
        public string? Nombres {get; set;}
        [Required(ErrorMessage ="Los medio de contacto son obligatorios")]
        public long Telefono {get; set;}
        [Required(ErrorMessage ="Los medio de contacto son obligatorios")]
        public long Celular {get; set;}
         [Required(ErrorMessage ="El RNC es obligatorio")]
        public long RNC {get; set;}
        [Required(ErrorMessage ="El Email es obligatorio")]
        public string? Email {get; set;}

        [Required(ErrorMessage ="La direccion es obligatoria")]
        public string? Direccion {get; set;}
      

}