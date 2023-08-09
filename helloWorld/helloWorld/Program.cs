//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//// programa que calcula el area de un rectangulo

//double ladoA;
//double ladoB;
//double resultado;

//Console.WriteLine("calcula el area de un rectangulo!");
//Console.WriteLine("ingresa el valor de el lado a");
//ladoA = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("ingresa el valor del lado b");
//ladoB = Convert.ToDouble(Console.ReadLine());
//resultado = ladoB * ladoA;
//Console.WriteLine("el lado a es: "+ladoA+", el lado b es: "+ladoB+", y el resultado es "+resultado);
//----------------------------------------------------------------------------------------------------------------------------

using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral Data Types
            //byte myByte = 255;          // 8-bit unsigned integer
            //short myShort = 32000;      // 16-bit signed integer
            //int myInt = 1000000;        // 32-bit signed integer
            //long myLong = 999999999;    // 64-bit signed integer

            // Floating-Point Data Types
            //float myFloat = 3.14f;      // 32-bit floating point
            //double myDouble = 3.14159;  // 64-bit floating point
            //decimal myDecimal = 123.45m;// 128-bit decimal

            // Character Data Type
            //char myChar = 'A';          // 16-bit Unicode character

            // Boolean Data Type
            //bool myBool = true;         // Represents true or false

            // String Data Type
            //string myString = "Hello, C#!"; // Represents a sequence of characters


            //--------------------------------------------------------------------------------------
            //Exercise 1: Calculate the Area of a Circle

            //Declare a variable radius of type double.
            //Assign a value to radius representing the radius of a circle.
            //Calculate the area of the circle using the formula: area = Math.PI * radius * radius.
            //Print the calculated area.
            Console.WriteLine("calcule el area de un circulo");
            Console.WriteLine("introduzca el radio");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
            //----------------------------------------------------------------------------------------
            //Exercise 2: Convert Kilometers to Miles

            //Declare a variable kilometers of type double.
            //Assign a value to kilometers representing a distance in kilometers.
            //Convert the distance from kilometers to miles using the formula: miles = kilometers * 0.621371.
            //Print the original distance in kilometers and the converted distance in miles.
            Console.WriteLine("introduzca el numero de kilometros");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double miles = kilometers * 0.621371;

            Console.WriteLine($"original distance is: {kilometers}, converted distance to miles is: {miles}");

            //Exercise 3: Calculate the Hypotenuse of a Right Triangle

            //Declare two variables sideA and sideB of type double.
            //Assign values to sideA and sideB representing the two shorter sides of a right triangle.
            //Calculate the length of the hypotenuse using the Pythagorean theorem: hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB).
            //Print the calculated length of the hypotenuse.
            double ladoA =4.44;
            double ladoB =2.22;
            double hypotenuse = Math.Sqrt(ladoA * ladoA + ladoB * ladoB);

            Console.WriteLine($"hypotenuse is equal to: {hypotenuse}");
        }
    }
}