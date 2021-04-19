using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SOL_MARIO_HUAMAN.Models
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string NumeroCelular { get; set; }
        public decimal Salario { get; set; }
        
        public int IdDepartamento { get; set; }
        public bool EsJefe { get; set; }

        //  [ForeignKey("fk_departamentos")]
        public virtual Departamento Departamento { get; set; }
    }
}