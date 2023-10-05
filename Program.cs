using Practica_Mia.Datos;
//ARREGLOS
//DEBE ABRIR Y CERRAR LOS COMENTARIOS
//DE CADA EJERCICIO (NO TODOS A LA VEZ) PARA EJECUTARLOS
Datos datos = new Datos();
/*################################## EJERCICIO 1 ################*/
int[] a = datos.P1();
datos.P1_1(a);
/*################################## EJERCICIO 2 ################*/
int[] b = datos.P2();
datos.P2_2(b);
/*################################## EJERCICIO 3 ################*/
int[] c = datos.P3();
datos.P3_3(c);
/*################################## EJERCICIO 4 ################
//NO SERVI :C
int[] d = datos.P4();
datos.P4_4(d);
/*################################## EJERCICIO 5 ################*/

Console.WriteLine("Ingrese el tamaño de los arreglos: ");
    int cant = Convert.ToInt32(Console.ReadLine());
    string[] e = datos.P5(cant);
    int[] ee = datos.P5_5(e);

    Console.WriteLine("\n--------------------------------------\n");
    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine("El arreglo " + e[i] + " tiene la longitud: " + ee[i] + "\n");
    }













