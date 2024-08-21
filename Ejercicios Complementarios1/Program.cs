using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

#region Menu

int respuesta;
bool validar;
string pregunta;

do
{
    Menu();
    pregunta = Console.ReadLine();
    validar = int.TryParse(pregunta, out respuesta);
    if (validar == false)
    {
        Console.Clear();
        break;
    }
    else
    {
        switch (respuesta)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Ejercicio5();
                break;
            case 6:
                Ejercicio6();
                break;
            case 7:
                Ejercicio7();
                break;
            case 8:
                Ejercicio8();
                break;
            case 9:
                Ejercicio9();
                break;
            case 10:
                Ejercicio10();
                break;
            case 11:
                Ejercicio11();
                break;
            case 12:
                Ejercicio12();
                break;
            case 13:
                Ejercicio13();
                break;
            case 14:
                Ejercicio14();
                break;
            case 15:
                Ejercicio15();
                break;
            case 16:
                Ejercicio16();
                break;
            case 17:
                Ejercicio17();
                break;
            case 18:
                Ejercicio18();
                break;
            case 19:
                Ejercicio19();
                break;
            case 20:
                Ejercicio20();
                break;
            case 21:
                Ejercicio21();
                break;
            default:
                break;
        }
        Console.WriteLine("\n");
        Console.WriteLine("Desea volver al menu? Si/No");
        pregunta = Console.ReadLine().ToLower();
        Console.Clear();
    }
    
} while (pregunta == "si");

#endregion 

#region Funciones

static void Menu()
{
    Console.WriteLine("------------------------------MENU------------------------------");
    Console.WriteLine("Ingrese un numero para ir al ejercicio");
    Console.WriteLine("\n");
    Console.WriteLine("1.Ejercicio N°1");
    Console.WriteLine("2.Ejercicio N°2");
    Console.WriteLine("3.Ejercicio N°3");
    Console.WriteLine("4.Ejercicio N°4");
    Console.WriteLine("5.Ejercicio N°5");
    Console.WriteLine("6.Ejercicio N°6");
    Console.WriteLine("7.Ejercicio N°7");
    Console.WriteLine("8.Ejercicio N°8");
    Console.WriteLine("9.Ejercicio N°9");
    Console.WriteLine("10.Ejercicio N°10");
    Console.WriteLine("11.Ejercicio N°11");
    Console.WriteLine("12.Ejercicio N°12");
    Console.WriteLine("13.Ejercicio N°13");
    Console.WriteLine("14.Ejercicio N°14");
    Console.WriteLine("15.Ejercicio N°15");
    Console.WriteLine("16.Ejercicio N°16");
    Console.WriteLine("17.Ejercicio N°17");
    Console.WriteLine("18.Ejercicio N°18");
    Console.WriteLine("19.Ejercicio N°19");
    Console.WriteLine("20.Ejercicio N°20");
    Console.WriteLine("21.Ejercicio N°21");
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese una letra para salir");
    Console.WriteLine("------------------------------MENU------------------------------");
}



static void Ejercicio1()
{
    Console.Clear();
    Console.WriteLine("Ejercicio numero 1: Dado un valor, verificar valor es mayor que 100");
    int numero;
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());

    if (numero >= 100)
    {
        Console.WriteLine("El valor es mayor que 100.");
    }
    else
    {
        Console.WriteLine("El valor es menor que 100.");
    }
}

static void Ejercicio2()
{
    Console.Clear();
    Console.WriteLine("Ejercicio 2. Pedir un número entero por teclado y calcular si es par o impar.");
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
}



static void Ejercicio3()
{
    Console.Clear();
    Console.WriteLine("Ejercicio 3: Dado un valor entero, se verifica si se cumple o no que ese valor es el doble de un impar.");
    int numero;
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
    if (((numero / 2) % 2) == 0)
    {
        Console.WriteLine("El valor no cumple la condicion");
    }
    else
    {
        Console.WriteLine("El valor cumple la condicion");
    }
}

static void Ejercicio4()
{
    int numero;
    Console.Clear();
    Console.WriteLine("Ejercicio 4: Dada un número del 1 al 10, devolver su “versión” en números romanos");
    Console.WriteLine("Ingrese un numero del 1 al 10");
    numero = int.Parse(Console.ReadLine());

    switch (numero)
    {
        case 1:
            Console.WriteLine("I");
            break;
        case 2:
            Console.WriteLine("II");
            break;
        case 3:
            Console.WriteLine("III");
            break;
        case 4:
            Console.WriteLine("VI");
            break;
        case 5:
            Console.WriteLine("V");
            break;
        case 6:
            Console.WriteLine("VI");
            break;
        case 7:
            Console.WriteLine("VII");
            break;
        case 8:
            Console.WriteLine("VIII");
            break;
        case 9:
            Console.WriteLine("XI");
            break;
        case 10:
            Console.WriteLine("X");
            break;
        default:
            break;
    }
}

static void Ejercicio5()
{
    string nombre1;
    string nombre2;
    int edad1;
    int edad2;
    Console.Clear();
    Console.WriteLine("Ejercicio 5: Leer el nombre y las edades de dos personas y devolver el nombre del menor.En caso de que tengan la misma edad también debe indicarse.Devolver también la diferencia de edad en caso de corresponder.");
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
    
}

static void Ejercicio6()
{
    int lado1;
    int lado2;
    int lado3;
    int cont;
    int perimetro;
    int altura;
    int baseTriangulo;
    double aux;
    double area;

    Console.Clear();
    Console.WriteLine("Ejercicio 6: Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.");
    aux = 0;
    area = 0;
    cont = 0;
    altura = 0;
    baseTriangulo = 0;

    Console.WriteLine("Ingrese el longitud del primer lado");
    lado1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el longitud del segundo lado");
    lado2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el longitud del tercer lado");
    lado3 = int.Parse(Console.ReadLine());

    //EQUILÁTERO: Tiene los tres lados iguales.
    //ISÓSCELES: Tiene al menos dos lados iguales.
    //ESCALENO: Tiene los tres lados desiguales

    if (lado1 == lado2)
        cont = cont + 1;
    if (lado1 == lado3)
        cont = cont + 1;
    if (lado2 == lado3)
        cont = cont + 1;
    perimetro = lado1 + lado2 + lado3;
    switch (cont)
    {
        case 0:
            Console.WriteLine("Es un triangulo ESCALENO");
            aux = (lado1 + lado2 + lado3) / 2;
            area = Math.Sqrt(aux * (aux - lado1) * (aux - lado2) * (aux - lado3));
            break;
        case 1:
            Console.WriteLine("Es un triangulo ISÓSCELES");
            if (lado1 == lado2)
            {
                baseTriangulo = lado3;
                altura = lado1;
            }
            else if (lado1 == lado3)
            {
                baseTriangulo = lado2;
                altura = lado1;
            }
            else 
            {
                baseTriangulo = lado1;
                altura = lado2;
            }
            
            
            area = (0.5 * baseTriangulo * altura);
            break;
        case 3:
            Console.WriteLine("Es un triangulo EQUILÁTERO");
            area = (Math.Sqrt(3) / 4) * Math.Pow(lado1, 2);
            break;
        default:
            break;
    }
    Console.WriteLine($"El perimetro es: {perimetro}");
    Console.WriteLine($"El area es: {area}");
}

static void Ejercicio7()
{
    Console.Clear();
    Console.WriteLine("Ejercicio 7: Desarrolle un programa que calcule el desglose de una cantidad dada, en\r\nbilletes y monedas tal que se minimice la cantidad de monedas y billetes.\r\nConsidere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,\r\ndonde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe\r\nimprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de $20,\r\n1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y tratar todos\r\nlos valores como números, para los cálculos.");

    int[] denom = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
    int dinero;
    int aux;
    //denominaciones = {1000, 500, 100, 50, 20, 10, 5, 2, 1};
    //Console.WriteLine(denom[0]);
    Console.WriteLine("Ingrese un monto");
    dinero = int.Parse(Console.ReadLine());
    aux = 0;


    while (dinero != 0)
    {
        if ((dinero - denom[aux]) >= 0)
        {
            if (aux < 6)
            {
                Console.WriteLine($"1 billete de: {denom[aux]}");
            }
            else
            {
                Console.WriteLine($"1 moneda de: {denom[aux]}");
            }
            dinero = dinero - denom[aux];
        }
        if (dinero != 0)
        {
            while ((dinero - denom[aux]) < 0)
            {
                aux = aux + 1;
            }
        }
        else
        {
            break;
        }
        Console.WriteLine($"{dinero}");
    }
    Console.WriteLine("Saliendo...");
}

static void Ejercicio8()
{
    int numero;
    Console.Clear();
    Console.WriteLine("Ejercicio 8: Pide un número N, y muestra todos los números del 1 al N.");
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());

    for (int i = 0; i <= numero; i++)
    {
        Console.WriteLine(i);
    }
}


static void Ejercicio9()
{
    int numero;
    int suma;
    Console.Clear();
    Console.WriteLine("Ejercicio 9: Pedir 15 números y escribir la suma total");
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
    suma = 0;

    for (int i = 0; i <= numero; i++)
    {
        suma = suma + i;
    }
    Console.WriteLine($"La suma total es: {suma}");
}


static void Ejercicio10()
{
    Console.Clear();
    Console.WriteLine("Ejercicio 10: Pide 5 números e indica si alguno es múltiplo de 3.");
    int tamaño = 5;
    int[] numeros = new int[tamaño];

    for (int i = 0; i < tamaño; i++)
    {
        Console.WriteLine("Ingrese 5 numeros");
        numeros[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < tamaño; i++)
    {
        if ((numeros[i] % 3) == 0)
            Console.WriteLine($"{numeros[i]}: es multiplo de 3");
    }
}



static void Ejercicio11()
{
    string pass;
    string pass2;
    Console.Clear();
    Console.WriteLine("Ejercicio 11. Escriba un programa que solicite una contraseña (el texto de la contraseña no es importante) y la vuelva a solicitar hasta que las dos contraseñas coincidan.\r\n");

    do
    {
        Console.WriteLine("Ingrese su contraseña");
        pass = Console.ReadLine();

        Console.WriteLine("Confirmar contraseña");
        pass2 = Console.ReadLine();

        if (pass != pass2)
            Console.WriteLine("Error!, Vuelve a intentarlo.");

    } while (pass != pass2);
    Console.WriteLine("Contraseña Confirmada!");
}

static void Ejercicio12()
{
    string pass;
    string pass2;
    int cont;
    cont = 0;
    Console.Clear();
    Console.WriteLine("Ejercicio 12. Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres peticiones no debe solicitar más la contraseña y terminar el programa.");
    do
    {
        Console.WriteLine("Ingrese su contraseña");
        pass = Console.ReadLine();

        Console.WriteLine("Confirmar contraseña");
        pass2 = Console.ReadLine();

        if (pass != pass2)
        {
            if (cont == 2)
            {
                Console.WriteLine("Intentelo mas tarde...");
                break;
            }
            else
            {
                Console.WriteLine("Error!, Vuelve a intentarlo.");
                cont++;
            }
        }
        else
        {
            Console.WriteLine("Contraseña Confirmada!");
        }
    } while (pass != pass2);
}

static void Ejercicio13()
{
    int numero;
    int numUsu;
    Console.Clear();
    Console.WriteLine("Ejercicio 13. Proponer al usuario que adivine un número a base de intentarlo.");
    numero = 14;
    do
    {
        Console.WriteLine("Ingrese un numero");
        numUsu = int.Parse(Console.ReadLine());
    } while (numUsu != numero);
    Console.WriteLine("Felicidades!, Adivinaste!");
}



static void Ejercicio14()
{
    int numero;
    int numUsu;
    Console.Clear();
    Console.WriteLine("Ejercicio 14. Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor»");
    numero = 14;
    do
    {
        Console.WriteLine("Ingrese un numero");
        numUsu = int.Parse(Console.ReadLine());
        if (numUsu < numero)
        {
            Console.WriteLine("Ingrese un numero mayor");
        }
        else if (numUsu > numero)
        {
            Console.WriteLine("Ingrese un numero menor");
        }
    } while (numUsu != numero);
    Console.WriteLine("Felicidades!, Adivinaste!");
}



static void Ejercicio15()
{
    int numero;
    int aux;
    string respuesta;
    bool valido;
    aux = 0;
    Console.Clear();
    Console.WriteLine("Ejercicio 15. Crea un programa que permita sumar N números. El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’.\r\n");
    do
    {
        Console.WriteLine("Ingrese un numero o la palabra fin para terminar.");
        respuesta = Console.ReadLine();
        valido = int.TryParse(respuesta, out numero);
        if (valido == true)
        {
            aux = aux + numero;
        }
    } while (valido == true);
    Console.WriteLine($"El suma es igual a: {aux}");
}




static void Ejercicio16()
{
    string palabra;
    int cont;
    char[] arregloChar;
    bool bandera;

    Console.Clear();
    Console.WriteLine("Ejercicio 16. Crea un programa que solicite al usuario una cadena de texto y que verifique si es o no un palíndromo\r\n");
    bandera = true;
    cont = 0;
    Console.WriteLine("Ingrese una palabra");
    palabra = Console.ReadLine();


    for (int i = palabra.Length - 1; i >= 0; i--)
    {
        if (palabra[i] == palabra[cont])
        {
            cont = cont + 1;
        }
        else
        {
            bandera = false;
            break;
        }

    }
    if (bandera == true)
    {
        Console.WriteLine($"{palabra} es un palindromo");
    }
    else
    {
        Console.WriteLine($"{palabra} NO es un palindromo");
    }
}


static void Ejercicio17()
{
    int numero;
    int factorial;
    Console.Clear();
    Console.WriteLine("Ejercicio 17. Pide al usuario un número x y calcula su factorial");
    Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());
    factorial = 1;
    for (int i = 1; i < numero; i++)
    {
        factorial = factorial + factorial * i;
    }
    Console.WriteLine("El factorial del numero " + numero + " es " + factorial);
}



static void Ejercicio18()
{
    int temperatura;
    int convert;
    string respuesta;

    Console.Clear();
    Console.WriteLine("Ejercicio 18. Crea un programa que convierta una temperatura en grados Celsius a Fahrenheit o viceversa según la elección del usuario.\r\n");
    Console.WriteLine("Escriba el tipo de temperatura al que desea convertir: Celsius/Fahrenheit ");
    respuesta = Console.ReadLine().ToLower();

    Console.WriteLine("Ingresa la temperatura");
    temperatura = int.Parse(Console.ReadLine());

    if (respuesta == "celsius")
    {
        convert = (temperatura - 32) * 5 / 9;
        Console.WriteLine($"Temperatura en Celsius: {convert}");
    }
    else
    {
        convert = (temperatura * 9 / 5) + 32;
        Console.WriteLine($"Temperatura en Fahrenheit: {convert}");
    }
}


static void Ejercicio19()
{
    int numero;
    int[] fibo;
    Console.Clear();
    Console.WriteLine("Ejercicio 19. Solicita al usuario un número entero positivo y muestra los primeros 50 números de la secuencia de Fibonacci\r\n");
    Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());
    fibo = new int[numero + 1];
    for (int i = 0; i <= numero; i++)
    {
        if (i == 0)
        {
            fibo[i] = 0;
        }
        else if (i == 1)
        {
            fibo[i] = 1;
        }
        else
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
    }
    Console.WriteLine("El fibonacci de " + numero + " es " + fibo[numero]);
}


static void Ejercicio20()
{

    Console.Clear();
    Console.WriteLine("Ejercicio 20. Desarrolla un juego en el que el programa elija una palabra y el usuario tenga que adivinarla letra por letra, con un límite de intentos.\r\n");
    
    int numAle;
    int cont;
    int contLetras;

    char letra;
    bool contiene;
    bool bandera;
    string palabra;
    string palabraDesc;
    string[] palabras = ["caballo", "camion", "serpiente", "helicoptero", "casa"];

    Random numRandom = new Random();
    numAle = numRandom.Next(0, 4);
    palabra = palabras[numAle];
    contiene = false;

    cont = 0;

    contLetras = 0;

    char[] textoDesc = new char[palabra.Length];
    string[] letrasUsadas = new string[27]; //las letras totales del abecedario son 27

    for (int j = 0; j < palabras[numAle].Length; j++)
    {
        textoDesc[j] = '_';
    }
    for (int i = 0; i < palabras[numAle].Length; i++)
    {
        do
        {

            Console.WriteLine($"Intento {i} de {palabras[numAle].Length}.");
            Console.WriteLine("Ingrese una Letra");
            letra = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            bandera = false; // inicializo el booleano.    

            for (int j = 0; j < contLetras; j++)// Verifico que no sea una letra repetida.
            {
                if (letrasUsadas[j] == letra.ToString())
                    bandera = true;
            }
            if (bandera == true)
            {
                Console.Clear();
                Console.WriteLine($"Letra ingresada: {letra}");
                Console.WriteLine("Ya utilizaste esta letra, intenta con otra");
            }
        } while (bandera == true);//Obligo al usuario a ingresar una letra que no haya ingresado antes.

        letrasUsadas[contLetras] = letra.ToString();
        contLetras = contLetras + 1;

        contiene = false; // inicializo el booleano.
        contiene = palabra.Contains(letra);

        if (contiene == true)
        {
            Console.WriteLine("Acertaste!");
            for (int j = 0; j < palabras[numAle].Length; j++)
            {
                if (letra == palabras[numAle][j])
                {
                    textoDesc[j] = (letra);
                    cont = cont + 1;
                }
            }
        }
        else
        {
            Console.WriteLine("Fallaste");
        }

        if (cont == palabra.Length)
            break;

        palabraDesc = "";
        for (int k = 0; k < palabra.Length; k++) //Muestro la palabra descubierta hasta el momento.
        {
            palabraDesc = palabraDesc + textoDesc[k];
        }
        Console.WriteLine($"{palabraDesc}");
    }

    if (cont == palabra.Length)
    {
        Console.WriteLine("Felicidades, Adivinaste!.");
    }
    else
    {
        Console.WriteLine("Fallaste, Suerte la proxima.");
    }
}

static void Ejercicio21()
{
    Console.Clear();
    Console.WriteLine("Ejercicio 21. Adaptar el programa anterior para que a medida que el usuario falle, la aplicación autocomplete la palabra letra a letra a modo de pistas para el usuario. El numero de intentos estará dado por la cantidad de letras restantes que el usuario tenga que adivinar. Ejemplo: La palabra ADIVINAR tendrá 8 intentos. Si la forma de la palabra es AD_V_NA_ son 3 intentos\r\n");

    int numAle;
    int cont;
    int contLetras;
    int ayuda;
    char letra;
    bool contiene;
    bool bandera;
    string palabra;
    string palabraDesc;
    string[] palabras = ["caballo", "camion", "serpiente", "helicoptero", "casa"];

    Random numRandom = new Random();
    numAle = numRandom.Next(0, 4);
    palabra = palabras[numAle];

    contiene = false;
    ayuda = 0;
    cont = 0;
    contLetras = 0;

    char[] textoDesc = new char[palabra.Length];
    string[] letrasUsadas = new string [27]; //las letras totales del abecedario son 27
    for (int j = 0; j < palabra.Length; j++)
    {
        textoDesc[j] = '_';
    }
    for (int i = 0; i < palabra.Length; i++)
    {
        do
        {
            
            Console.WriteLine($"Intento {i} de {palabras[numAle].Length}.");
            Console.WriteLine("Ingrese una Letra");
            letra = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            bandera = false; // inicializo el booleano.    

            for (int j = 0; j < contLetras; j++)// Verifico que no sea una letra repetida.
            {
                if (letrasUsadas[j] == letra.ToString())
                    bandera = true;
            }
            if (bandera == true)
            {
                Console.Clear();
                Console.WriteLine($"Letra ingresada: {letra}");
                Console.WriteLine("Ya utilizaste esta letra, intenta con otra");
            }
        } while (bandera == true);//Obligo al usuario a ingresar una letra que no haya ingresado antes.

        letrasUsadas[contLetras] = letra.ToString();
        contLetras = contLetras + 1;

        contiene = false; // inicializo el booleano.
        contiene = palabra.Contains(letra);

        if (contiene == true)
        {
            Console.WriteLine("Acertaste!");
            for (int j = 0; j < palabra.Length; j++)
            {
                if (letra == palabra[j])
                {
                    textoDesc[j] = letra;
                    cont = cont + 1;
                }
            }
        }
        else
        {
            Console.WriteLine("Fallaste");
            ayuda = ayuda + 1;
        }

        if (cont == palabra.Length)
            break;

        if (ayuda == 2)
        {
            for (int j = 0; j < palabra.Length; j++)
            {
                if (textoDesc[j] == '_')
                {
                    textoDesc[j] = palabras[numAle][j];
                    ayuda = 0;
                    break;
                }
            }
        }
        palabraDesc = "";
        for (int k = 0; k < palabras[numAle].Length; k++) //Muestro la palabra descubierta hasta el momento.
        {
            palabraDesc = palabraDesc + textoDesc[k];
        }
        Console.WriteLine($"{palabraDesc}");
    }

    if (cont == palabra.Length)
    {
        Console.WriteLine("Felicidades, Adivinaste!.");
    }
    else
    {
        Console.WriteLine("Fallaste, Suerte la proxima.");
    }
}


#endregion


