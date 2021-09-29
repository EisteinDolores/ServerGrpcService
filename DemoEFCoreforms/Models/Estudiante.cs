using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCoreforms.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public EstudianteDetalle Detalle{ get; set; }
        public List<EstudianteCurso> EstudianteCursos { get; set; }

    }
}
