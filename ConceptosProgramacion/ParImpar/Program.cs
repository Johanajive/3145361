var i = 1;
do
{
    Console.Write($"Ingrese el número {i} y que sea número Entero:");
    var numString = (Console.ReadLine());

    if (int.TryParse(numString, out int numInt))
    {
        if (numInt % 2 == 0)
        {
            Console.WriteLine($"El número {numInt} es Par");
        }
        else
        {
            Console.WriteLine($"El número {numInt} es Impar");
        }
    }
    else
    {
        Console.WriteLine("El valor '" + numString + "' no es un numero Entero");
    }
    i++;
} while (i <= 3);