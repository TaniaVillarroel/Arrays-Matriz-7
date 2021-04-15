using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7Lilo
{
    class claseAlumno
    {
        string nombre;
        int nota1;
        int nota2;
        int nota3; 

        public string pNombre
        {
            set{nombre = value;}
            get{return nombre;}
        }

        public int pNota1
        {
            set{nota1 = value;}
            get{return nota1;} 
        }

        public int pNota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }

        public int pNota3
        {
            set { nota3 = value; }
            get { return nota3; }
        }


        public  claseAlumno()
        {
            nombre = "";
            nota1 = nota2 =  nota3 = 0; 
        }

        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string toString()
        {
            return "El promedio del alumno " + nombre + " es " + calcularPromedio();
                 
        }

    }
}
