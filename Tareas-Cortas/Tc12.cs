﻿using System;
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
	Encontrar el K-esimo elemento las grande en un arreglo desordenado, notese que es el k-esimo elemento en el arreglo ordenado, no el k-esimo elemento distinto.
	ejemplo:
	[3,2,1,5,6,4], k=2 -> retorna 5
*/

//Your code starts here
namespace Tareas_Cortas
{
    ///<summary>
    /// Leo el arreglo y el dato 
    /// con la funcion Array.Sort ordeno el arreglo
    /// obtengo el tamaño le resto el vamos a consultar
    /// y busco en el arreglo el campo con la resta
    /// y retorno la solucion
    ///</summary>
    class Tc12
    {
        public int datos(int[] dato, int dato2)
        {
            int res = 0;
            int tamano = dato.Length;
            int num = tamano - dato2;
            Array.Sort(dato);
            res = dato[num];
            return res;
        }
    }
}