using System;
using System.ComponentModel;
//Ejercicios Opcionales

//Ejercicio 1: Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
//sólo cuando se cumpla dicha condición.
/*
int numero;

if (numero > 100)
    Console.WriteLine("El valor es mayor que 100.");

//Ejercicio 2. Pedir un número entero por teclado y calcular si es par o impar.

int numero;
Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
if ((numero % 2) == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}

// Ejercicio 3: Teniendo un valor entero, verificar si se cumple o no que ese valor es el
// doble de un impar. Por ejemplo, 14 cumple con esta condición.

int numero;
numero = 16;
if ( ((numero / 2) % 2) == 0)
{
    Console.WriteLine("El valor no cumple la condicion");
}else
{
    Console.WriteLine("El valor cumple la condicion");
}
*/
//Ejercicio 4: Dada un número del 1 al 10, devolver su “versión” en números romanos.

int numero;
numero = 14;
Console.WriteLine(Version(numero));