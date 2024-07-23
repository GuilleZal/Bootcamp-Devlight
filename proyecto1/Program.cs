using System;
/*
int Temperatura;
int Respuesta;
int Respuesta2;

do
{
    Console.WriteLine("Ingrese la temperatura actual en grados Celcius");
    Temperatura = int.Parse(Console.ReadLine());

    switch (Temperatura)
    {
        case < 0:
            Console.WriteLine("Hace mucho frío afuera, asegúrate de abrigarte bien.");
            break;
        case > 20:
            Console.WriteLine("Hace calor afuera, no necesitas una chaqueta.");
            break;
        case <= 20:
            Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");
            break;
        default:
            break;
    }

    Console.WriteLine("¿Desea conocer el pronóstico para los próximos cinco días?.");
    Console.WriteLine("Ingrese 1 para Aceptar");
    Console.WriteLine("Ingrese 0 para Salir");
    Respuesta = int.Parse(Console.ReadLine());
    if (Respuesta == 1)
    {
        Console.WriteLine("Pronostico para los siguientes 5 dias:");
        Console.WriteLine("Lunes: 12° ");
        Console.WriteLine("Martes: 22° ");
        Console.WriteLine("Miercoles: 30° ");
        Console.WriteLine("Jueves: 20° ");
        Console.WriteLine("Viernes: 15° ");
    }

    Console.WriteLine("¿Desesa realizar otra consulta?");
    Console.WriteLine("Ingrese 1 para Aceptar");
    Console.WriteLine("Ingrese 0 para Salir");
    Respuesta2 = int.Parse(Console.ReadLine());
} while (Respuesta2 == 1);
Console.WriteLine("Saliendo...");

*/

//Ejercicios Opcionales

//Ejercicio 1: Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
//sólo cuando se cumpla dicha condición.
/*
int numero;

if (numero > 100)
    Console.WriteLine("El valor es mayor que 100.");

//Ejercicio 2. Pedir un número entero por teclado y calcular si es par o impar.

Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
if ((numero mod 2) == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}
*/
// Ejercicio 3: Teniendo un valor entero, verificar si se cumple o no que ese valor es el
// doble de un impar. Por ejemplo, 14 cumple con esta condición.
int numero;
numero = 14;
if (((numero / 2) Mod 2) == 0)
{
    Console.WriteLine("El valor no cumple la condicion");
}else
{
    Console.WriteLine("El valor cumple la condicion");
}



