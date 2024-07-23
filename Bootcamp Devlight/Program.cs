
using System;

int Temperatura;
string Respuesta;
bool valido;

do
{
    do
    {
        Console.WriteLine("Ingrese la temperatura actual en grados Celcius");
        Respuesta = Console.ReadLine();
        valido = int.TryParse(Respuesta, out Temperatura);
    } while (valido != true);
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

    Console.WriteLine("¿Desea conocer el pronóstico para los próximos cinco días?. \nSi/No");
    Respuesta = Console.ReadLine().ToLower();

    while (Respuesta != "no")
    {
        if (Respuesta == "si")
        {
            Console.WriteLine("Pronostico para los siguientes 5 dias:");
            Console.WriteLine("Lunes: 12° ");
            Console.WriteLine("Martes: 22° ");
            Console.WriteLine("Miercoles: 30° ");
            Console.WriteLine("Jueves: 20° ");
            Console.WriteLine("Viernes: 15° ");
            break;
        }
        Console.WriteLine("Debes escribir: Si/No");
        Respuesta = Console.ReadLine().ToLower();
    }

    Console.WriteLine("¿Desesa realizar otra consulta? \nSi/No");
    Respuesta = Console.ReadLine().ToLower();
    while (Respuesta != "si")
    {
        if (Respuesta == "no")
            break;
        Console.WriteLine("Debes escribir: Si/No");
        Respuesta = Console.ReadLine().ToLower();
    }
} while (Respuesta == "si");
Console.WriteLine("Saliendo...");

