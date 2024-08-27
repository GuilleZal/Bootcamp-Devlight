using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Obligatorio3
{
    public abstract class Persona()
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }


        public abstract string TipoPersona();
    }


    public class Pasante : Persona
    {
        public int Legajo { get; set; }

        public Pasante(string nombre, string apellido, int edad, int legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Legajo = legajo;
        }
        public override string TipoPersona()
        {
            return "Pasante";
        }
    }

    public class Profesional : Persona
    {
        public int Matricula {  get; set; }
        public Profesional(string nombre, string apellido, int edad, int matricula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Matricula = matricula;
        }
        public override string TipoPersona()
        {
            return "Profesional";
        }
    }

    public class RegistroTemperatura
    {
        public int TemperaturaRegistrada { get; set; }
        public Persona PersonaTurno { get; set; }
        public DateTime FechaHora { get; set; }


        public RegistroTemperatura(int temperatura, Persona persona, DateTime fechahora)
        {
            TemperaturaRegistrada = temperatura;
            PersonaTurno = persona;
            FechaHora = fechahora;
        }
    }

    public class EstacionMeteorologica
    {
        public Pasante[] Pasantes { get; set; }
        public Profesional[] Profesionales { get; set; }
        public RegistroTemperatura[,,] Mes {  get; set; }

        public EstacionMeteorologica(Pasante[] pasante, Profesional[] profesional)
        {
            Mes = new RegistroTemperatura[5,7,3];
            Pasantes = pasante;
            Profesionales = profesional;
        }


        public void RegistrarTemperatura()
        {
            ModificarMatriz();
            /*
            En este metodo voy a reemplazar los valores que ya se encuentran en la matriz, 
            ya que los registros en la matriz se genera automaticamente.


            Ejemplo del registro actual en la matriz:    
            
            Fecha y Hora: 26/08/2024 22:50:00
            Cargo: Profesional
            Persona de Turno: Valeria Cerutti
            Temperatura: 38
            
            Suponiendo que hoy es el dia "26" y es la hora " 23:00 hs" del tercer turno del dia
            y quiero registrar o modificar una temperatura quedaria:

            Fecha y Hora: 26/08/2024 23:00:00
            Cargo: Profesional
            Persona de Turno: Valeria Cerutti
            Temperatura: 4

            Al usuario solo se le pide la temperatura, y luego guardo la hora actual.

            */
        }

        public RegistroTemperatura[,,] CargarMatriz()
        {
            // Aqui genero una matriz automaticamente con horarios y turnos aleatorios.
            int ContadorDias = 1;
            int ProfesionalIndice = 0;
            int PasanteIndice = 0;
            int HoraTurno = 0;
            
            for (int semana = 0; semana < Mes.GetLength(0); semana++)
            {
                for (int dia = 0; dia < Mes.GetLength(1); dia++)
                {
                    for (int turno = 0; turno < Mes.GetLength(2); turno++)
                    {

                        Random numRandom = new Random();
                        int numAle = numRandom.Next(-10, 49);
                        if (turno == 0)
                        {
                            Random numRandom2 = new Random();
                            HoraTurno = numRandom2.Next(0, 7);
                            
                        }
                        else if (turno == 1)
                        {
                            Random numRandom2 = new Random();
                            HoraTurno = numRandom2.Next(8, 15);
                        }
                        else if (turno == 2)
                        {
                            Random numRandom2 = new Random();
                            HoraTurno = numRandom2.Next(16, 23); ;
                        }

                        DateTime fechahora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, ContadorDias, HoraTurno, 50, 00);

                        if ((semana + dia + turno) % 2 == 0)
                        {

                            RegistroTemperatura registro = new RegistroTemperatura(numAle, Pasantes[PasanteIndice], fechahora);
                            PasanteIndice = (PasanteIndice + 1) % Pasantes.Length; // Ciclo circular
                            Mes[semana, dia, turno] = registro;
                        }
                        else
                        {
                            RegistroTemperatura registro = new RegistroTemperatura(numAle, Profesionales[ProfesionalIndice], fechahora);
                            ProfesionalIndice = (ProfesionalIndice + 1) % Profesionales.Length; // Ciclo circular
                            Mes[semana, dia, turno] = registro;
                        }
                        
                    }
                    ContadorDias++;
                    if (ContadorDias > 31)
                        break;
                }

            }

            return Mes;
        }

        private RegistroTemperatura[,,] ModificarMatriz()
        {
            Console.WriteLine("Registrar temperatura 1: Si / 2: No");
            int Respuesta = int.Parse(Console.ReadLine());
            if (Respuesta == 1)
            {
                Console.WriteLine("Ingrese la temperatura");
                int Temperatura1 = int.Parse(Console.ReadLine());
                int Hora = DateTime.Now.Hour;
                int ContadorDias = 1;
                for (int semana = 0; semana < Mes.GetLength(0); semana++)
                {
                    for (int dia = 0; dia < Mes.GetLength(1); dia++)
                    {
                        if (ContadorDias == DateTime.Now.Day)
                        {
                            if ((Hora >= 0) && (Hora <= 7))
                            {
                                Mes[semana, dia, 0].FechaHora = DateTime.Now;
                                Mes[semana, dia, 0].TemperaturaRegistrada = Temperatura1;
                            }
                            else if ((Hora >= 8) && (Hora <= 15))
                            {
                                Mes[semana, dia, 1].FechaHora = DateTime.Now;
                                Mes[semana, dia, 1].TemperaturaRegistrada = Temperatura1;
                            }
                            else if ((Hora >= 16) && (Hora <= 23))
                            {
                                Mes[semana, dia, 2].FechaHora = DateTime.Now;
                                Mes[semana, dia, 2].TemperaturaRegistrada = Temperatura1;
                            }
                            break;
                        }
                        ContadorDias++;
                    }
                }
            }
            return Mes;
        }

        public void TemperaturasDia(int TempDia)
        {
            

            int ContadorDias = 1;
            for (int semana = 0; semana < Mes.GetLength(0); semana++)
            {
                for (int dia = 0; dia < Mes.GetLength(1); dia++)
                {
                    if (TempDia == ContadorDias)
                    {
                        Console.WriteLine($"La temperatura del dia {TempDia} es: " + Mes[semana, dia, 0].TemperaturaRegistrada + $" a las {Mes[semana, dia, 0].FechaHora.Hour} hs");
                        Console.WriteLine($"La temperatura del dia {TempDia} es: " + Mes[semana, dia, 1].TemperaturaRegistrada + $" a las {Mes[semana, dia, 1].FechaHora.Hour} hs");
                        Console.WriteLine($"La temperatura del dia {TempDia} es: " + Mes[semana, dia, 2].TemperaturaRegistrada + $" a las {Mes[semana, dia, 2].FechaHora.Hour} hs");
                        return;
                    }
                    ContadorDias++;
                }
            }
        }

        public void TemperaturasSemana(int TempSemana)
        {
            Console.WriteLine("Temperaturas de la semana: " + TempSemana + " del mes " + DateTime.Now.Month);
            for (int dia = 0; dia < Mes.GetLength(1); dia++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"La temperatura del dia {Mes[TempSemana, dia,0].FechaHora.Day} es: " + Mes[TempSemana, dia, 0].TemperaturaRegistrada + $" a las {Mes[TempSemana, dia, 0].FechaHora.Hour} hs");
                Console.WriteLine($"La temperatura del dia {Mes[TempSemana, dia, 1].FechaHora.Day} es: " + Mes[TempSemana, dia, 1].TemperaturaRegistrada + $" a las {Mes[TempSemana, dia, 1].FechaHora.Hour} hs");
                Console.WriteLine($"La temperatura del dia {Mes[TempSemana, dia, 2].FechaHora.Day} es: " + Mes[TempSemana, dia, 2].TemperaturaRegistrada + $" a las {Mes[TempSemana, dia, 2].FechaHora.Hour} hs");
            }
        }

        public void VerMatriz()
        {
            RegistroTemperatura registro;
            int ContadorDias = 1;
            for (int semana = 0; semana < Mes.GetLength(0); semana++)
            {
                for (int dia = 0; dia < Mes.GetLength(1); dia++)
                {
                    for (int turno = 0; turno < Mes.GetLength(2); turno++)
                    {
                        registro = Mes[semana, dia, turno];
                        Console.WriteLine("");
                        Console.WriteLine("Fecha y Hora: " + registro.FechaHora);
                        if ( registro.PersonaTurno.TipoPersona() == "Pasante")
                        {
                            Console.WriteLine("Cargo: Pasante");
                        }
                        else
                            Console.WriteLine("Cargo: Profesional");
                        Console.WriteLine($"Persona de Turno: {registro.PersonaTurno.Nombre} {registro.PersonaTurno.Apellido}");
                        Console.WriteLine("Temperatura: " + registro.TemperaturaRegistrada);
                    }

                    ContadorDias++;
                    if (ContadorDias > 31)
                        break;
                }
            }
        }
        
    }


}