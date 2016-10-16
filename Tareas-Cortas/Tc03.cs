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
	Tarea Corta 3
	Estudiante: [Matias Horacio Hroncich]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/
namespace Tareas_Cortas
{///<summary>
 ///Realice un foreach para recorrer la lista y la comparo
 ///con el elemento, la lista es de un string 
 ///en este caso el dato tiene que ser igual, compara exacto con 
 ///las mayusculas y las minusculas
 ///No se utilizo una funcion para practicar, en funcion podria
 ///usar String.Compare
 ///</summary>
    class Tc03
    {
        public string lista(List<string> dato, string dato2)
        {
            String res = "";
            int resultado = 0;
            foreach (string line in dato)
            {
                if (dato2 == line)
                {
                    resultado++;
                }
            }
            res = resultado.ToString();
            return res;
        }
    }
}

