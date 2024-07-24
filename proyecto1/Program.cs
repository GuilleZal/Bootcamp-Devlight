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
Console.WriteLine("Ingrese un numero del 1 al 10");
numero = int.Parse(Console.ReadLine());

switch numero
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
    
        else
        {
            Console.WriteLine($" El/La menor es: {nombre2} ");
            Console.WriteLine($"La diferencia de edad es: {edad1 - edad2}");
        }
    }


//Ejercicio 6: Escribir un programa que calcule el tipo de un triángulo conociendo la
//longitud de sus 3 lados. También que calcule su perímetro y su área.

int lado1;
int lado2;
int lado3;
int cont;
int area;

cont = 0;
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
    cont = cont+1;
if (lado1 == lado3)
    cont = cont + 1;
if (lado2 == lado3)
    cont = cont + 1;
area = lado1 + lado2 + lado3;
switch (cont)
{
    case 0:
        Console.WriteLine("Es un triangulo ESCALENO");
        break;
    case 1:
        Console.WriteLine("Es un triangulo ISÓSCELES");
        break;
    case 3:
        Console.WriteLine("Es un triangulo EQUILÁTERO");
        break;
    default:
        break;
}

Console.WriteLine($"El area es: {area}");


//Ejercicio 7: Desarrolle un programa que calcule el desglose de una cantidad dada, en
//billetes y monedas tal que se minimice la cantidad de monedas y billetes.
//Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
//donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
//imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de $20,
//1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y tratar todos
//los valores como números, para los cálculos.


int[] denom = {1000, 500, 100, 50, 20, 10, 5, 2, 1};
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



//Ejercicio 8: Pide un número N, y muestra todos los números del 1 al N.

int numero;

Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());

for (int i=0; i<=numero; i++)
{
    Console.WriteLine(i);
}


// Ejercicio 9: Pedir 15 números y escribir la suma total

int numero;
int suma;
Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
suma = 0;

for (int i = 0; i<= numero; i++)
{
    suma = suma+i;
}
Console.WriteLine($"La suma total es: {suma}");



//Ejercicio 10: Pide 5 números e indica si alguno es múltiplo de 3.

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

//Ejercicio 11. Escriba un programa que solicite una contraseña (el texto de la contraseña
//no es importante) y la vuelva a solicitar hasta que las dos contraseñas coincidan.

string pass;
string pass2;

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



//Ejercicio 12. Mismo que el anterior pero con un límite de tres peticiones. Luego de las
//tres peticiones no debe solicitar más la contraseña y terminar el programa.

string pass;
string pass2;
int cont;
cont = 0;
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


//Ejercicio 13. Proponer al usuario que adivine un número a base de intentarlo.

int numero;
int numUsu;

numero = 14;
do
{
    Console.WriteLine("Ingrese un numero");
    numUsu = int.Parse(Console.ReadLine());
} while (numUsu != numero);
Console.WriteLine("Felicidades!, Adivinaste!");


//Ejercicio 14. Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor»

int numero;
int numUsu;

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



//Ejercicio 15. Crea un programa que permita sumar N números. El usuario decide cuándo
//termina de introducir números al indicar la palabra ‘fin’.

int numero;
int aux;
string respuesta;
bool valido;
aux = 0;
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



//Ejercicio 16. Crea un programa que solicite al usuario una cadena de texto y que
//verifique si es o no un palíndromo

string palabra;
int cont;

char[] arregloChar;
bool bandera;
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


//Ejercicio 17. Pide al usuario un número x y calcula su factorial

int numero;
Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    
}


//Ejercicio 18. Crea un programa que convierta una temperatura en grados Celsius a
//Fahrenheit o viceversa según la elección del usuario.

int temperatura;
int convert;
string respuesta;

Console.WriteLine("Escriba el tipo de temperatura al que desea convertir: Celsius/Fahrenheit ");
respuesta = Console.ReadLine().ToLower();

Console.WriteLine("Ingresa la temperatura");
temperatura = int.Parse(Console.ReadLine());

if (respuesta == "celsius")
{
    convert = (temperatura - 32) * 5/9;
    Console.WriteLine($"Temperatura en Celsius: {convert}");
}
else
{
    convert = (temperatura * 9/5) + 32;
    Console.WriteLine($"Temperatura en Fahrenheit: {convert}");
}



//Ejercicio 19. Solicita al usuario un número entero positivo y muestra los primeros 50
//números de la secuencia de Fibonacci



//Ejercicio 20. Desarrolla un juego en el que el programa elija una palabra y el usuario
//tenga que adivinarla letra por letra, con un límite de intentos.

int numAle;
int cont;
char letra;
bool contiene;
string texto;
string[] palabras = ["auto", "camion", "serpiente", "lago", "casa"];

Random numRandom = new Random();
numAle = numRandom.Next(0, 4);
texto = palabras[numAle];
contiene = false;
cont = 0;

for(int i = 0; i < palabras[numAle].Length; i++)
{
    Console.WriteLine($"Intento {i} de {palabras[numAle].Length}.");
    Console.WriteLine("Ingrese una Letra");
    letra = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");
    contiene = texto.Contains(letra);
    if (contiene == true )
    {
        cont = cont + 1;
        Console.WriteLine("Acertaste!");
    }
    else
    {
        Console.WriteLine("Fallaste");
    }
    contiene = false;
}
if (cont == palabras[numAle].Length)
{
    Console.WriteLine("Felicidades, Adivinaste!.");
}
else
{
    Console.WriteLine("Fallaste, Suerte la proxima.");
}

*/

//21 (EXTRA). Adaptar el programa anterior para que a medida que el usuario
//falle, la aplicación autocomplete la palabra letra a letra a modo de pistas para
//el usuario. El numero de intentos estará dado por la cantidad de letras
//restantes que el usuario tenga que adivinar. Ejemplo: La palabra ADIVINAR
//tendrá 8 intentos. Si la forma de la palabra es AD_V_NA_ son 3 intentos



