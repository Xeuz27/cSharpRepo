// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// programa que calcula el area de un rectangulo

double ladoA;
double ladoB;
double resultado;

Console.WriteLine("calcula el area de un rectangulo!");
Console.WriteLine("ingresa el valor de el lado a");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingresa el valor del lado b");
ladoB = Convert.ToDouble(Console.ReadLine());
resultado = ladoB * ladoA;
Console.WriteLine("el lado a es: "+ladoA+", el lado b es: "+ladoB+", y el resultado es "+resultado);