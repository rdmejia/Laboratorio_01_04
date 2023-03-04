// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: Operaciones aritmeticas");

Console.Write("Ingrese un numero: ");
int n1 = Convert.ToInt32(Console.ReadLine()); // 5

Console.Write("Ingrese otro numero: ");
int n2 = Convert.ToInt32(Console.ReadLine()); // 3

int suma = n1 + n2;
Console.WriteLine(n1 + "+" + n2 + "=" + suma);

int resta = n1 - n2;
Console.WriteLine(n1 + "-" + n2 + "=" + resta);

int multiplicacion = n1 * n2;
Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion);

int div = n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + div);

int mod = n1 % n2;
Console.WriteLine(n1 + "%" + n2 + "=" + mod);

double n1d = n1;
double n2d = n2;

double division = (double)n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + division);
