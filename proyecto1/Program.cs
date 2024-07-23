using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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

//Ejercicio 4: Dada un número del 1 al 10, devolver su “versión” en números romanos.

int numero;
numero = 14;
Console.WriteLine(Version(numero));



//Ejercicio 5: Leer el nombre y las edades de dos personas y devolver el nombre del
//menor.En caso de que tengan la misma edad también debe indicarse.
//Devolver también la diferencia de edad en caso de corresponder.

string nombre1;
string nombre2;
int edad1;
int edad2;

Console.WriteLine("Ingrese el nombre de la primera persona");
nombre1 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la primera persona");
edad1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el nombre de la segunda persona");
nombre2 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la segunda persona");
edad2 = int.Parse(Console.ReadLine());

if (edad1 < edad2)
{
    Console.WriteLine($"El/La menor es: {nombre1}");
    Console.WriteLine($"La diferencia de edad es: {edad2 - edad1}");
}
else if (edad1 == edad2)
{
    Console.WriteLine("Ambos tienen la misma edad");
}
else
{
    Console.WriteLine($" El/La menor es: {nombre2} ");
    Console.WriteLine($"La diferencia de edad es: {edad1 - edad2}");
}
*/

//Ejercicio 6: Escribir un programa que calcule el tipo de un triángulo conociendo la
//longitud de sus 3 lados. También que calcule su perímetro y su área.

int lado1;
int lado2;
int lado3;

Console.WriteLine("Ingrese el valor de un lado")
Console.ReadLine()
