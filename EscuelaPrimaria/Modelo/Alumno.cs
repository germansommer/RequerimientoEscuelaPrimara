using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Modelo
{
    class Alumno
    {
        public String Nombre;
        public List<Evaluacion> Evaluaciones;
        
        public Alumno(String nombre)
        {
            this.Nombre = nombre;
            this.Evaluaciones = new List<Evaluacion>();
        }

        public void RecorridoNotas()
        {
            foreach(Evaluacion e in Evaluaciones)
            {
                Console.WriteLine("La nota de " + this.Nombre + "en " + e.Materia + "es de " + e.Nota);
            }
        }
    }
}
