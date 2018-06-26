using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Universidad.DbModels
{
    public partial class Alumno
    {
        public Alumno()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idalumno { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "minimo 6 caracteres")]
        
        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        [Required]
        public DateTime? FechaNacimiento { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
