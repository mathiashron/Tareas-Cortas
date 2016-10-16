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
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 2
	Estudiante: [Matias Horacio Hroncich]
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here
namespace Tareas_Cortas
{
    class Tc02
    {

        ///<summary>
        ///Se creo dos funciones una para imprimir la lista original
        ///y otra para imprimir la lista invertida
        ///en este caso se programo todo no se utilizo funciones
        ///la primera recorre la lista con un foreach y retorna el resultado
        ///para ser impreso 
        ///La segunda se uso un for y se va guardando el resultado en forma 
        ///inversa en este caso la lista es de un String dado que no indica
        ///de que tipo es.
        ///</summary>
        public string lista(List<string> dato)
        {
            string res = "";
            foreach (string line in dato)
            {
                res = res + line + " ";
             }
                
                return res;
            
        }
        public string listainver(List<string> dato)
        {
            string res = "";
            int y = dato.Count-1;
            for (int x = y; x >= 0; x--)
            {
                
                res = res + dato.ElementAt(x) + " ";
            }

            return res;

        }

    }
}
