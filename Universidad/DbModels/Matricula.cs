using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.DbModels
{
    public partial class Matricula
    {
        public int Idmatricula { get; set; }
        [Required]
        public int? Idalumno { get; set; }
        [Required]
        public int? Idprofesor { get; set; }
        public int? Idmateria { get; set; }

        [Required]
        public double? Nota { get; set; }

        public Alumno IdalumnoNavigation { get; set; }
        public Materia IdmateriaNavigation { get; set; }
        public Profesor IdprofesorNavigation { get; set; }
    }
}
