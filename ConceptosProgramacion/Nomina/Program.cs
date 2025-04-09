const decimal salarioMinimo = 1500000;
const int horasMensuales = 160;
decimal valorHora = salarioMinimo / horasMensuales;
int cantidadHorasDomingo = 0;

Console.WriteLine("Ingrese su Nombre: ");
var nombre = Console.ReadLine();

Console.WriteLine("Ingrese sus horas trabajadas: ");
var horasTrabajadas =int.Parse( Console.ReadLine());

Console.WriteLine("¿Trabajo el Domingo? SI/NO");
var trabajoDomingo = Console.ReadLine().ToLower();


if (trabajoDomingo == "si")
{
    Console.WriteLine("Cantidad de horas trabajadas el domingo: ");
    cantidadHorasDomingo = int.Parse(Console.ReadLine());
}

var horasNormales = horasTrabajadas * valorHora;
Console.WriteLine($"TOTA HORAS NORMALES: {horasTrabajadas} X" + $" {valorHora:N0} =" + $" {horasNormales:N0}");

var valorHoraDominicales = cantidadHorasDomingo * valorHora * 2;
Console.WriteLine($"TOTAL HORAS DOMINICALES: {cantidadHorasDomingo} X"  + $" {valorHora:N0} =" + $" {valorHoraDominicales:N0}");
    
var totalApagar = horasNormales + valorHoraDominicales;
Console.WriteLine($"TOTAL A PAGAR = {totalApagar:N0}"); 
