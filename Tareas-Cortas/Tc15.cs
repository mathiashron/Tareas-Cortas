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
	Estudiante: [Your Name]
	
	Enunciado:
	Encontrar duplicado: Usted va a recibir un arreglo de 100 elementos, que contiene numeros del 1 al 100, exactamente un elemento esta duplicado, 
	debe retornar el numero duplicado en el arreglo
*/

//Your code starts here
namespace Tareas_Cortas
{///<summary>
 /// Lo que realizo son dos for anidados
 /// uno con las x para tomar el un elemento
 /// luego con las y las voy comparando con el resto
 /// se reliza este proceso hasta que encuentre uno duplicado o al terminar de recorrer la matriz
 /// con los if el primero es para descartar comparar el mismo elemento 
 /// el segundo para la verificar si son iguales
 /// si son iguales envia el resultado y finaliza el proceso
 ///</summary>
    class Tc15
    {
        public int datos(int[] dato)
        {
            int res = 0;
            for (int x = 0; x <= dato.Length-1; x++)
            {
                for (int y = 0; y <= dato.Length-1; y++)
                {
                    if (x == y)
                    {}
                    else
                    {
                        if (dato[x] == dato[y])
                        {
                            res = dato[x];
                            break;
                        }
                    }
                }
            }

            return res;
        }
    }
}
