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
	Tarea Corta 1
	Estudiante: [Matias Horacio Hroncich]
	
	Enunciado:
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/

//Your code starts here
namespace Tareas_Cortas
{///<summary>
 ///recibo un String con los parentecis con un for voy leyendo cada campo
 ///y con un if lo comparo con un ( si es correcto sumo un contador si no es correcto
 ///sumo otro contador al final el for con otro if
 ///comparo la cantidad si son iguales envio un True si no son un false
 ///</summary>
    class Tc08
    {
        public bool datos(string dato)
        {
            bool res = false;
            int cant = dato.Length;
            //string par1 = ")";
            //string par2 = "(";
            int cantp1 = 0;
            int cantp2 = 0;
            for (int x = 0; x <= dato.Length - 1; x++)
            {
                if (dato[x].ToString() == "(")
                {
                    cantp1++;
                }
                else
                {
                    cantp2++;
                }
            }

            if (cantp1 == cantp2)
            {
                res = true;
            }
            return res;
        }
    }
}
