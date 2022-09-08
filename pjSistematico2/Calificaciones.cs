using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjSistematico2
{
    public class Calificaciones
    {
        private string nombreEstudiante { get; set; }
        private int nota1 { get; set; }
        private int nota2 { get; set; }
        private int nota3 { get; set; }

        public double ObtenerPromedio()
        {
            double prom = nota1 + nota2 + nota3 / 3;

            return prom;
        }
    
    }

  
}
