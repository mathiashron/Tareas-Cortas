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
            Console.WriteLine("Falta");
            Tc05 tarea5 = new Tc05();

            //Tarea#6
            Console.WriteLine("Tarea #6");
            Tc06 tarea6 = new Tc06();
            String palindromo2 = "aace";
            string val6 = tarea6.datos(palindromo2);
            Console.WriteLine("La palabra mas corta del Palindromo: {0} ", val6);



            //Tarea#8
            Console.WriteLine("Tarea #8");
            Tc08 tarea8 = new Tc08();
            String parentes = "(())";
            bool val8 = tarea8.datos(parentes);
            Console.WriteLine("los parentesis estan : {0} ", val8);
            

            //Tarea#9
            Console.WriteLine("Tarea #9");
            Tc09 tarea9 = new Tc09();
            String palabra = "the sky is blue";
            string val9 = tarea9.datos(palabra);
            Console.WriteLine("La palabra invertida es: {0} ", val9);

            //Tarea#12
            Console.WriteLine("Tarea #12");
            Tc12 tarea12 = new Tc12();
            int [] arreglo = new int[] { 1, 3, 5, 2, 8, 9, 4 };
            int dato2 = 2;
            int val12 = tarea12.datos(arreglo,dato2);
            Console.WriteLine("el K-esimo elemento mas grande es: {0} ", val12);

            //Tarea#15
            Console.WriteLine("Tarea #15");
            Tc15 tarea15 = new Tc15();
            int[] arreglo1 = new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14,15,16,17,18,18,19,20,21,22,23,24,25,26,27,28,29,30 };
            int val15 = tarea15.datos(arreglo1);
            Console.WriteLine("El elemento repetido es: {0} ", val15);

            //Tarea#16
            Console.WriteLine("Tarea #16");
            Tc16 tarea16 = new Tc16();
            tarea16.datos();
            //int val16 = tarea16.datos();
            //Console.WriteLine("El elemento repetido es: {0} ", val16);

            //Tarea#17
            Console.WriteLine("Tarea #17");
            Tc17 tarea17 = new Tc17();
            string datos = "abcdefghijklmnopqrstuvwxyzabcdfghabcd";
            tarea17.datos(datos);
            //Console.WriteLine("El elemento repetido es: {0} ", val17);



            Console.Read();
        }
    }
}
