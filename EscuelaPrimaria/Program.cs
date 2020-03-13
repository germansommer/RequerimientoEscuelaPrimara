using System;
using EscuelaPrimaria.Modelo;

namespace EscuelaPrimaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Grado PrimerGrado = new Grado(1);
            Grado SegundoGrado = new Grado(2);
            Grado TercerGrado = new Grado(3);
            Grado CuartoGrado = new Grado(4);
            Grado QuintoGrado = new Grado(5);
            Grado SextoGrado = new Grado(6);
            Grado SeptimoGrado = new Grado(7);

            Alumno Alumno1 = new Alumno("Daniel");
            Alumno Alumno2 = new Alumno("Damian");
            Alumno Alumno3 = new Alumno("Ricardo");
            Alumno Alumno4 = new Alumno("Marcos");
            Alumno Alumno5 = new Alumno("Marcelo");
            Alumno Alumno6 = new Alumno("Pablo");
            Alumno Alumno7 = new Alumno("Javier");
            Alumno Alumno8 = new Alumno("Gabriel");
            Alumno Alumno9 = new Alumno("Fabio");
            Alumno Alumno10 = new Alumno("Alejandro");
            Alumno Alumno11 = new Alumno("Lucia");
            Alumno Alumno12 = new Alumno("Daniela");
            Alumno Alumno13 = new Alumno("Sara");
            Alumno Alumno14 = new Alumno("Carla");
            Alumno Alumno15 = new Alumno("Martina");
            Alumno Alumno16 = new Alumno("Sofia");
            Alumno Alumno17 = new Alumno("Natalia");
            Alumno Alumno18 = new Alumno("Paula");
            Alumno Alumno19 = new Alumno("Gabriela");
            Alumno Alumno20 = new Alumno("Clara");

            PrimerGrado.Alumnos.Add(Alumno1);
            PrimerGrado.Alumnos.Add(Alumno2);
            PrimerGrado.Alumnos.Add(Alumno3);
            PrimerGrado.Alumnos.Add(Alumno4);
            PrimerGrado.Alumnos.Add(Alumno5);
            PrimerGrado.Alumnos.Add(Alumno6);
            PrimerGrado.Alumnos.Add(Alumno7);
            PrimerGrado.Alumnos.Add(Alumno8);
            PrimerGrado.Alumnos.Add(Alumno9);
            PrimerGrado.Alumnos.Add(Alumno10);
            PrimerGrado.Alumnos.Add(Alumno11);
            PrimerGrado.Alumnos.Add(Alumno12);
            PrimerGrado.Alumnos.Add(Alumno13);
            PrimerGrado.Alumnos.Add(Alumno14);
            PrimerGrado.Alumnos.Add(Alumno15);
            PrimerGrado.Alumnos.Add(Alumno16);
            PrimerGrado.Alumnos.Add(Alumno17);
            PrimerGrado.Alumnos.Add(Alumno18);
            PrimerGrado.Alumnos.Add(Alumno19);
            PrimerGrado.Alumnos.Add(Alumno20);

            PrimerGrado.Alumnos.Add(Alumno1);
            PrimerGrado.Alumnos.Add(Alumno1);
            PrimerGrado.Alumnos.Add(Alumno1);
            PrimerGrado.Alumnos.Add(Alumno1);

            PrimerGrado.RecorridoAlumnos();
        }
    }
}
