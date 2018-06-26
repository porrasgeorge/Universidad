using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.DbModels
{
    public partial class Materia
    {
        public Materia()
        {
            Matricula = new HashSet<Matricula>();
        }

       
        public int Idmateria { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "minimo 6 caracteres")]
        public string Nombre { get; set; }
        [Required]
        public int? Estado { get; set; }
        public double Precio { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
