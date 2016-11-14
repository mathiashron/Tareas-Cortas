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
	Estudiante: [Your Name]
	
	Enunciado:
	Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci
	Fibonacci -> https://en.wikipedia.org/wiki/Fibonacci_number
*/

//Your code starts here
namespace Tareas_Cortas
{///<summary>
 /// La secuencia de fibonacci es inicia con 0 y 1 y los suma 0 +1 =1
 /// luego suma el anterior con el ultimo 1+1 =2 1+2=3 2+3=4 ....
 /// Lo que realizo es eso crear dos long dato1 y dato2
 /// los imprimo para tener el 0 1 inicial
 /// luego los sumo y cambio dato1 por dato2 y dato2 por la suma hasta llegar a los 100
 ///</summary>
    class Tc16
    {
        public void datos()
        {
            double dato1 = 0;
            double dato2 = 1;
            Console.Write("({0} {1} )",dato1,dato2);
            for (int x = 0; x <= 100; x++)
            {


                double res = dato1 + dato2;

                Console.Write("{0} ",res);
                dato1 = dato2;
                dato2 = res;
            }
            Console.WriteLine();

        }
    }
}