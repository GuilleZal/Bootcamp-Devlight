
using Ejercicio_Obligatorio3;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Obligatorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesional[] Profesionales = new Profesional[3];
            Pasante[] Pasantes = new Pasante[3];
            RegistroTemperatura [,,] Mes = new RegistroTemperatura[5, 7, 3];

            Pasantes[0] = new Pasante("Juan", "Espinoza", 28, 24536);
            Pasantes[1] = new Pasante("Carlos", "Mendez", 24, 22532);
            Pasantes[2] = new Pasante("Sergio", "Bordon", 27, 28352);
            Profesionales[0] = new Profesional("Lucia", "Ortiz", 22, 36234);
            Profesionales[1] = new Profesional("Guille", "Ramirez", 29, 16234);
            Profesionales[2] = new Profesional("Valeria", "Cerutti", 25, 28214);
            
            EstacionMeteorologica estacion = new EstacionMeteorologica(Pasantes, Profesionales, Mes);

            Mes = estacion.CargarMatriz();
            estacion.VerMatriz(); //este metodo lo utilizaba para guiarme nada mas.

            Console.WriteLine("");

            estacion.RegistrarTemperatura();
            estacion.VerMatriz();

            Console.WriteLine("");

            Console.WriteLine("Del 1 al 5, ingrese en que semana desea ver las temperaturas");
            int TemperaturasSem = int.Parse(Console.ReadLine());
            estacion.TemperaturasSemana(TemperaturasSem);

            Console.WriteLine("");

            Console.WriteLine("Ingrese el dia para ver las temperaturas");
            int TemperaturasDia = int.Parse(Console.ReadLine());
            estacion.TemperaturasDia(TemperaturasDia);

            Console.WriteLine("");

            Console.WriteLine("Promedio de temperaturas del Mes es: " + Calculos.CalcularTemperaturaPromedio(Mes)+"°");


        }
    }
}
