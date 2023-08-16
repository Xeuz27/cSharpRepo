// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ricardo perez ID");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Perez";
string informacion = "nacio en hidalgo, es estudiante de gastronomia y astronomia";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"la informacion de {nombre} es: \n " +
    $"{informacion} y es {hobby} y tiene {edad} años y mide {altura}";

Console.WriteLine(tarjetaDeIdentificacion);