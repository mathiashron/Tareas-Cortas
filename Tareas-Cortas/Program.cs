using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_Cortas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea#1
            Console.WriteLine("Tarea #1");
            Tc01 tarea1 = new Tc01();
            List<int> lista = new List<int>(new int[] { 7, 3, 5,8,1,6,10,2 });
            int val = tarea1.lista(lista);
            Console.WriteLine("El elemento mas grande es {0}", val);

            //Tarea#2
            Console.WriteLine("Tarea #2");
            Tc02 tarea2 = new Tc02();
            List<string> lista2 = new List<string>(new string[] { "uno", "dos", "tres", "cuatro", "cinco" });
            string val2 = tarea2.lista(lista2);
            string val22 = tarea2.listainver(lista2);
            Console.WriteLine("La lista original es {0}", val2);
            Console.WriteLine("La lista Invertida es {0}", val22);

            //Tarea#3
            Console.WriteLine("Tarea #3");
            Tc03 tarea3 = new Tc03();
            String elemento = "Matias";
            List<string> lista3 = new List<string>(new string[] { "uno", "dos", "tres", "matias", "cinco" });
            String val3 = tarea3.lista(lista3,elemento);
            Console.WriteLine("El resultado es {0}", val3);

            //Tarea#4
            Console.WriteLine("Tarea #4");
            Tc04 tarea4 = new Tc04();
            String palindromo = "ama";
            bool val4 = tarea4.datos(palindromo);
            Console.WriteLine("La palabra es un Palindromo: {0} ", val4);

            //Tarea#5
            Console.WriteLine("Tarea #5");
            Tc05 tarea5 = new Tc05();

            //Tarea#6
            Console.WriteLine("Tarea #6");
            Tc06 tarea6 = new Tc06();
            String palindromo2 = "aace";
            string val6 = tarea6.datos(palindromo2);
            Console.WriteLine("La palabra mas corta del Palindromo: {0} ", val6);

            Console.Read();



        }
    }
}
