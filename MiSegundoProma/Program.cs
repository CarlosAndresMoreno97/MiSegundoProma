﻿//Realizar un algoritmo que me pida 3 números por pantalla, con el primer número hallar el cuadrado, con el segundo número hallar la raíz cuadrada
//y con el tercer número hallar la raíz cúbica. Mostrar en pantalla los 3 resultados aritméticos.//

public class MiSegundoProma
{
    static void Main(string[] args)
    {
        double num1, num2, num3, potencia, raizCuadrada, raizCubica;

        Console.Write("Ingresa el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());
            
        Console.Write("Ingresa el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine()); 


        potencia = Math.Pow(num1, 2);
        raizCuadrada = Math.Sqrt(num2);
        raizCubica = Math.Cbrt(num3);


        Console.Write("La potencia es: " + potencia);
        Console.Write("\n");
        Console.Write("La raiz cuadrada es: " + raizCuadrada);
        Console.Write("\n");
        Console.Write("La raiz cubica es: " + raizCubica);
        Console.Write("\n");


    }
}
