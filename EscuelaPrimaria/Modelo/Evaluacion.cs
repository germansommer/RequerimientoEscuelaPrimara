using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Modelo
{
    class Evaluacion
    {
        public int Nota;
        public Materia Materia;        

        public Evaluacion(Materia materia)
        {
            Random random = new Random();
            this.Materia = materia;
            this.Nota = random.Next(1, 10);
        }
    }
}
