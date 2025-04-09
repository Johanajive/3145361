const decimal salarioMinimo = 1500000;
const int horasMensuales = 160;
decimal valorHora = salarioMinimo / horasMensuales;
int cantidadHorasDomingo = 0; // Inicializamos en 0

Console.WriteLine("Ingrese su Nombre: ");
var nombre = Console.ReadLine();

int horasTrabajadas;
bool horasValidas = false;

while (!horasValidas)
{
    Console.WriteLine("Ingrese sus horas trabajadas: ");
    var leerHorasTrabajadas = Console.ReadLine();

    // Validamos que las horas trabajadas sean un número válido y no excedan 624
    if (int.TryParse(leerHorasTrabajadas, out horasTrabajadas) && horasTrabajadas >= 0 && horasTrabajadas <= 624)
    {
        horasValidas = true;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero válido entre 0 y 624 para las horas trabajadas.");
    }
}

bool horasDomingoValidas = false;
while (!horasDomingoValidas)
{
    Console.WriteLine("¿Trabajo el Domingo? SI/NO");
    var trabajoDomingo = Console.ReadLine().ToLower();

    if (trabajoDomingo == "si")
    {
        // Validamos que las horas dominicales no excedan 94
        Console.WriteLine("Cantidad de horas trabajadas el domingo: ");
        if (int.TryParse(Console.ReadLine(), out cantidadHorasDomingo) && cantidadHorasDomingo >= 0 && cantidadHorasDomingo <= 94)
        {
            horasDomingoValidas = true;
        }
        else
        {
            Console.WriteLine("Ingrese un número válido de horas dominicales entre 0 y 94.");
        }
    }
    else if (trabajoDomingo == "no")
    {
        horasDomingoValidas = true; // Si no trabajó el domingo, no es necesario ingresar horas
    }
    else
    {
        Console.WriteLine("Por favor ingrese 'SI' o 'NO' cuando se le pregunte si trabajó el domingo.");
    }
}

// **Aquí** validamos que la suma de horas trabajadas normales y dominicales no exceda las 720
if (horasTrabajadas + cantidadHorasDomingo > 720)
{
    Console.WriteLine("La suma de las horas trabajadas normales y dominicales no puede exceder las 720 horas.");
}
else
{
    // Calculamos las horas normales y dominicales
    var horasNormales = horasTrabajadas * valorHora;
    Console.WriteLine($"TOTAL HORAS NORMALES: {horasTrabajadas} X {valorHora:N0} = {horasNormales:N0}");

    var valorHoraDominicales = cantidadHorasDomingo * valorHora * 2;
    Console.WriteLine($"TOTAL HORAS DOMINICALES: {cantidadHorasDomingo} X {valorHora:N0} = {valorHoraDominicales:N0}");

    // Calculamos el total a pagar
    var totalApagar = horasNormales + valorHoraDominicales;
    Console.WriteLine($"TOTAL A PAGAR = {totalApagar:N0}");
}