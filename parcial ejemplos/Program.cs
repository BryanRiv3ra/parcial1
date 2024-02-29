int numero;

do
{
    Console.WriteLine("Ingrese un número entero positivo (o ingrese 0 para salir):");
    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
    {
        Console.WriteLine("Número no válido. Ingrese un numero valido.");
        continue;
    }

    if (numero == 0)
    {
        Console.WriteLine("Esta saliendo del programa");
        break;
    }

    Console.WriteLine("Menú:");
    Console.WriteLine("1. Calcular el factorial del número.");
    Console.WriteLine("2. Calcular la raíz cuadrada del número.");
    Console.WriteLine("Elija una opción:");

    if (!int.TryParse(Console.ReadLine(), out int opcion))
    {
        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"El factorial de {numero} es: {CalcularFactorial(numero)}");
            break;
        case 2:
            Console.WriteLine($"La raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
            break;
    }
} while (true);

static long CalcularFactorial(int n)
{
    if (n == 0)
        return 1;
    long factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}
Console.WriteLine("---------------------------");

int num1, num2;
char operador;
double resultado = 0;

Console.WriteLine("Ingrese el primer número entero:");
if (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Entrada no valida.");
    return;
}

Console.WriteLine("Ingrese el segundo número entero:");
if (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Entrada no valida.");
    return;
}

Console.WriteLine("Ingrese el operador  (+, -, *, /):");
if (!char.TryParse(Console.ReadLine(), out operador))
{
    Console.WriteLine("Operador no valido.");
    return;
}

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
        {
            resultado = (double)num1 / num2;
        }
        else
        {
            Console.WriteLine("Division entre ceros no permitida.");
            return;
        }
        break;
    default:
        Console.WriteLine("operador no valido.");
        return;
}

Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
Console.WriteLine("--------------------------------");

Console.WriteLine("Ingrese un número del que desea saber su tabla de multiplicar:");
if (!int.TryParse(Console.ReadLine(), out int numero2))
{
    Console.WriteLine("Solo numeros enteros porfavor.");
    return;
}

Console.WriteLine($"Tabla de multiplicar del {numero2}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero2} x {i} = {numero2 * i}");
}
Console.WriteLine("---------------------------------");

Random random = new Random();
int numeroSecreto = random.Next(1, 10);
int intento;

Console.WriteLine("Jugaremos a adivina el numero secreto");
Console.WriteLine("El número secreto está entre 1 y 10.");

do
{
    Console.WriteLine("Introduce tu intento:");
    if (!int.TryParse(Console.ReadLine(), out intento))
    {
        Console.WriteLine("Introduce solo numeros validos. Porfavor.");
        continue;
    }

    if (intento < numeroSecreto)
    {
        Console.WriteLine("El número secreto es mayor.");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("El número secreto es menor.");
    }
    else
    {
        Console.WriteLine("Bien hecho adivinaste.");
        break;
    }
} while (true);
Console.WriteLine("---------------------------");



//string nombre = "Bryan";
//string frase = "Hola que tal mundo";
//// lenght
//Console.WriteLine(nombre.Length);
//Console.WriteLine(frase.Length);
//Console.WriteLine("---------------------------");
//// Substring
//Console.WriteLine(nombre.Substring(3));
//Console.WriteLine(frase.Substring(2, 5));
//Console.WriteLine("---------------------------");
////starts whit
//Console.WriteLine(frase.StartsWith("Hola"));
//Console.WriteLine(frase.StartsWith("mundo"));
//Console.WriteLine("---------------------------");
////endswhit
//Console.WriteLine(frase.EndsWith("mundo"));
//Console.WriteLine(frase.EndsWith("Hola"));
//Console.WriteLine("---------------------------");
//// to uper y to lower
//Console.WriteLine(nombre.ToUpper());
//Console.WriteLine(frase.ToLower());
//Console.WriteLine("---------------------------");
////indexOF
//int Cadenanombre = nombre.IndexOf("");
//int CadenaFrase = frase.IndexOf("Hola");
//Console.WriteLine(Cadenanombre);
//Console.WriteLine(CadenaFrase);
//Console.WriteLine("---------------------------");
//// Trim
//string TrimNombre = " HOLA  ";
//Console.WriteLine(TrimNombre.Trim());
//Console.WriteLine("---------------------------");
////Replace
//string replacejemplo = "Felcidades juan ganaste dinero hoy";
//string resultado3 = replacejemplo.Replace("juan", "Carl");
//resultado3 = replacejemplo.Replace("dinero", "un parcial");
//Console.WriteLine(resultado3);
//Console.WriteLine("---------------------------");
////Lastindexof
//int ejemplo = frase.LastIndexOf("Mundo");
//Console.WriteLine(ejemplo);
////operar +
//Console.WriteLine(nombre + "Dice" + frase);
//Console.WriteLine("---------------------------");
////isNullorWhiteSpace
//string ejemplo12 = "            ";
//string ejemploNull = null;
//Console.WriteLine(string.IsNullOrWhiteSpace(ejemplo12));
//Console.WriteLine(string.IsNullOrWhiteSpace(ejemploNull));
//Console.WriteLine("---------------------------");
////Concat
//string resultado2 = string.Concat(nombre, " esta haciendo un programa que dice: ", frase);
//Console.WriteLine("---------------------------");
////Format
//string mensaje = string.Format("Hola, me llamo {0} ", nombre);
//Console.WriteLine(mensaje);