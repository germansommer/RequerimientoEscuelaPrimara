using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Modelo
{
    class Grado
    {
        public int Curso;
        public List<Alumno> Alumnos;
        public List<Materia> Materias = new List<Materia>();
        

        public Grado(int curso)
        {
            this.Curso = curso;
            this.Alumnos = new List<Alumno>();
            this.Materias = new List<Materia>();

            Materia Lengua = new Materia("Lengua");
            Materia Matematica = new Materia("Matematica");
            Materia Musica = new Materia("Musica");
            Materia EducacionFisica = new Materia("EducacionFisica");

            this.Materias.Add(Lengua);
            this.Materias.Add(Matematica);
            this.Materias.Add(Musica);
            this.Materias.Add(EducacionFisica);        

        }

        public void RecorridoAlumnos()
        {
            foreach (Alumno a in Alumnos)
            {
                a.RecorridoNotas();
            }
        }
    }
}
