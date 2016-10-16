using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 6
	Estudiante: [Matias Horacio Hroncich]
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/

namespace Tareas_Cortas
{///<summary>
 ///en este caso para encontrar el palindromo mas corto
 ///lo que realizo es ir agrgando la primera letra al final 
 ///luego la invierto y la comparo con la inicial si no concuerda
 ///borro las variables involucradas y repito hasta encontrar que
 ///sean iguales, el string letras lo guardo por adelante para que
 ///la comparacion sea correcta.
 ///</summary>
    class Tc06
    {
        public string datos(string dato)
        {
            string res = "";
            String letras = "";
            String poli = "";
            String rever = "";
          for (int x = 0; x <= dato.Length-1; x++)
            {
             letras = dato[x] + letras;
                poli = dato + letras;
                for (int y = poli.Length-1; y >=0; y--)
                {
                    rever = rever + poli[y];
                }
                if (rever == poli)
                {
                    res = poli;
                    break;
                }
                else
                {
                    poli = "";
                    rever = "";
                }
            }

                return res;
        }

        }
}
