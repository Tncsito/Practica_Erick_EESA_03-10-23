﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Mia.Datos
{
    internal class Datos
    {
        /*######### EJERCICIO 1 ################
        public int[] P1()
        {
            int[] a = { 5, 5, 5, 5, 5 };
            return a;
        }
        public void P1_1(int[] a)
        {
            Console.WriteLine("Valores de los arreglos:");
            for (int aa = 0; aa < a.Length; aa++)
            {
                Console.WriteLine("Arreglo " + aa + ": " + a[aa]);
            }
        }
        /*######### EJERCICIO 2 ################
        public int[] P2()
        {
            int[] b = new int[5];

            for (int bb = 0; bb < 5; bb++)
            {
                Console.WriteLine("Dame un numero para el arreglo " + bb + ": ");
                if (int.TryParse(Console.ReadLine(), out int r))
                {
                    b[bb] = r;
                }
            }
            return b;
        }
        public void P2_2(int[] b)
        {
            Console.WriteLine("Valores de los arreglos:");
            for (int bb = 0; bb < b.Length; bb++)
            {
                Console.WriteLine("Arreglo " + bb + ": " + b[bb]);
            }
        }
        /*######### EJERCICIO 3 ################
        public int[] P3()
        {
            int[] c = new int[10];

            for (int cc = 0; cc < 10; cc++)
            {
                Console.WriteLine("Dame un numero para el arreglo " + (cc+1) + ": ");
                if (int.TryParse(Console.ReadLine(), out int r))
                {
                    c[cc] = r;
                }
            }
            return c;
        }
        public void P3_3(int[] c)
        {
            Console.WriteLine("Valores de los arreglos:");
            for (int cc = 0; cc < c.Length; cc++)
            {
                Console.WriteLine("Arreglo " + (cc+1) + ": " + c[cc]);
            }
            int sc = 0;
            foreach (int bc in c)
            {
                sc += bc;
            }
            double mc = (double) sc / c.Length;
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"\nLa media de los numeros es {mc}");
        }
        /*######### EJERCICIO 4 ################*/

        /*######### EJERCICIO 5 ################*/

    }
}
