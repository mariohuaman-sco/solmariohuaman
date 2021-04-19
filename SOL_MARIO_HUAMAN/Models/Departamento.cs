using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SOL_MARIO_HUAMAN.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Descripcion { get; set; }
        public int IdJefe { get; set; }
    }
}