using System;
using System.Collections.Generic;

namespace Universidad.DbModels
{
    public partial class Profesor
    {
        public Profesor()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idprofesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int? Estado { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
