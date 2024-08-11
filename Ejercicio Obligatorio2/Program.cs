

using System.Reflection;

int[,] Mes = new int[5, 7];
int opcion;
int contador;
bool bandera;
bool banderaMM;

do
{
    Console.WriteLine("----------  Elija una opcion:  ----------");
    Console.WriteLine("1) Cargar las temperaturas del mes ");
    Console.WriteLine("2) Utilizar temperaturas genericas");
    Console.WriteLine("3) Salir");
    bandera = int.TryParse(Console.ReadLine(), out opcion);
    if (bandera == true)
    {
        if (opcion > 0 && opcion < 4)
        {
            bandera = true;
        }
        else
        {
            bandera = false;
        }
    }
    Console.Clear();
} while (bandera == false);

if (opcion != 3)
{
    do 
    { 
        Console.WriteLine("Hasta que dia desea ingresar");
        bandera = int.TryParse(Console.ReadLine(), out contador);
        if (contador > 31)
        {
            bandera = false;
            Console.Clear();
        }
    }while (bandera == false);
    
}
else
    return;
Console.Clear();
switch (opcion)
{
    case 1:
        cargarTemperatura(Mes, contador);
        break;
    case 2:
        generarTemperatura(Mes, contador);
        break;
    case 3:
        break;
}

do
{
    do
    {
        Menu();
        bandera = int.TryParse(Console.ReadLine(), out opcion);
        if (bandera == true)
        {
            if (opcion > 0 && opcion < 9 )
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
        }
        Console.Clear();    
    } while (bandera == false);

    switch (opcion)
    {
        case 1:
            verTemperatura(Mes, contador);
            break;
        case 2:
            promedioSemana(Mes, contador);
            break;
        case 3:
            temperaturasVeinte(Mes, contador);
            break;
        case 4:
            promedioMes(Mes, contador);
            break;
        case 5:
            banderaMM = true;
            bajaAlta(Mes, banderaMM);
            break;
        case 6:
            banderaMM = false;
            bajaAlta(Mes, banderaMM);
            break;
        case 7:
            pronostico();
            break;
        case 8:
            break;
    }

    do
    {
        Console.WriteLine("¿Desea volver al menu?");
        Console.WriteLine("\n");
        Console.WriteLine("1) Si");
        Console.WriteLine("2) No");
        bandera = int.TryParse(Console.ReadLine(), out opcion);
        if (bandera == true)
        {
            if (opcion > 0 && opcion < 3)
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
        }
        Console.Clear();
    } while (bandera == false);

} while (opcion == 1);

#region Funciones

static void cargarTemperatura(int[,] mes, int cont)
{
    bool bandera;
    int temperatura;
    int auxiliar = 1;
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {

            if (auxiliar > cont)
            {
                break;
            }
            do 
            {
                Console.WriteLine("Ingrese la temperatura");
                bandera = int.TryParse(Console.ReadLine(), out temperatura);
                Console.Clear(); 
            }while (bandera == false);
            mes[i, j] = temperatura;
            auxiliar++; // Utilizo un contador auxiliar para saber si cargue hasta el dia que indico el usuario
            bandera = false;
        }
    }
    //return mes;
}

int[,] generarTemperatura(int[,] mes, int cont)
{
    int auxiliar = 1;
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            if (auxiliar > cont)
            {
                break;
            }
            Console.Clear();
            Random numRandom = new Random();
            int newAle = numRandom.Next(-10, 49);
            mes[i, j] = newAle;
            auxiliar++; // Utilizo un contador auxiliar para saber si cargue hasta el dia que indico el usuario
        }
    }
    return mes;
}

/*void verMes(int[,] mes)
{
    int auxiliar = 0;
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            if (auxiliar != contador)
            {    
                Console.WriteLine($"Dia {auxiliar+1} con: {mes[i, j]}°");
                auxiliar++;
            }
        }
    }
}*/

static void Menu()
{
    Console.Clear();
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("           Elija una opcion:");
    Console.WriteLine("\n");
    Console.WriteLine("1) Ver temperatura de un día específico ");
    Console.WriteLine("2) Calcular y ver temperaturas promedios de cada semana");
    Console.WriteLine("3) Ver temperaturas por encima de 20° ");
    Console.WriteLine("4) Ver la temperatura promedio del mes");
    Console.WriteLine("5) Ver la temperatura más alta");
    Console.WriteLine("6) Ver la temperatura más baja");
    Console.WriteLine("7) Ver el pronóstico de 5 días posteriores al mes");
    Console.WriteLine("8) Salir");
    Console.WriteLine("\n");
    Console.WriteLine("-----------------------------------------");
}

static void verTemperatura(int[,] mes, int cont)
{
    Console.WriteLine($"Ingrese un dia inferior o igual a {cont}");
    int dia = int.Parse(Console.ReadLine());
    int auxiliar = 1;
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            if (auxiliar == dia)
            {
                int temp = mes[i, j];

                if (temp < 0)
                {
                    Console.WriteLine($"El dia {dia} hizo mucho frío.");
                }
                else if (temp > 20)
                {
                    Console.WriteLine($"El dia {dia} hizo calor afuera");
                }
                else 
                {
                    Console.WriteLine($"El dia {dia} el clima estaba fresco.");
                }
                return;
                
            }
            else
            {
                auxiliar++;
            }
            
        }
        
    }
}

static void promedioSemana(int[,] mes, int cont)
{

    int[] promedio = new int[5];
    int semana = 0;
    int dias = 0;
    int contadorAux = 1;

    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            if (contadorAux <= cont)
            {
                if (contadorAux < 8 )
                {
                    semana += mes[i, j];
                    if (contadorAux == 7)
                    {
                        promedio[0] = semana / 7;
                        semana = 0;
                    }
                }
                else if (contadorAux < 15 ) 
                {
                    semana += mes[i, j];
                    if (contadorAux == 14)
                    {
                        promedio[1] = semana / 7;
                        semana = 0;
                    }

                }
                else if (contadorAux < 22)
                {
                    semana += mes[i, j];
                    if (contadorAux == 21)
                    {
                        promedio[2] = semana / 7;
                        semana = 0;
                    }
                }
                else if (contadorAux < 29)
                {
                    semana += mes[i, j];
                    if (contadorAux == 28)
                    {
                        promedio[3] = semana / 7;
                        semana = 0;
                    }
                }
                else if (contadorAux < 32)
                {
                    dias++;
                    semana += mes[i, j];
                    if (contadorAux == cont)
                    {
                        promedio[4] = semana / dias;
                    }
                }
            }
            else
                break;
            contadorAux++;
        }

    }
    for (int i = 0; i < promedio.Length; i++)
    {
        Console.WriteLine($"Semana {i + 1} con promedio de {promedio[i]}°");
    }
}

static void temperaturasVeinte(int[,] mes, int cont)
{
    int dias = 0;
    Dictionary<int, int> diasFrios = new Dictionary<int, int>();
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            dias++;
            if (mes[i,j] >= 20)
            {
                diasFrios[dias] = mes[i,j];
            }

        }
    }
    foreach (KeyValuePair<int, int> valor in diasFrios)
    {
        Console.WriteLine($"Dia: {valor.Key}, Temperatura: {valor.Value}°");
    }
}

static void promedioMes(int[,] mes, int cont)
{
    int tempAcum = 0;
    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            tempAcum += mes[i,j];
        }
    }
    int promedio = tempAcum / cont;
    Console.WriteLine($"La temperatura promedio de los {cont} dias del mes es: {promedio}°");
}

static void bajaAlta(int[,] mes, bool bandera)
{
    int maximo = -99;
    int minimo = 99;

    for (int i = 0; i < mes.GetLength(0); i++)
    {
        for (int j = 0; j < mes.GetLength(1); j++)
        {
            if (maximo < mes[i,j] )
            {
                maximo = mes[i,j];
            }
            if(minimo > mes[i, j])
            {
                minimo = mes[i, j];
            }
        }
    }
    if (bandera == true)
        Console.WriteLine($"La temperatura maxima del mes es: {maximo}");
    else
        Console.WriteLine($"La temperatura maxima del mes es: {minimo}");
}

static void pronostico()
{

    for (int i = 0; i < 5; i++)
    {
        Random numRandom = new Random();
        Console.WriteLine($"Pronostico para el dia: {i + 1} es de: {numRandom.Next(-10, 49)}°");

    }
}
#endregion

