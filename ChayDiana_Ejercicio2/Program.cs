Console.WriteLine("CONTROL DE ACCESO UNIVERSITARIO");
Console.WriteLine("Rol");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Tecnico IT");
Console.WriteLine("4. Visitante");
Console.WriteLine("Ingrese su rol (1-4):");
int rol = int.Parse(Console.ReadLine());
Console.WriteLine("Hora (0-23):");
double hora = double.Parse(Console.ReadLine());
Console.WriteLine("Día de la semana (1-7, donde 1 es lunes..., 7 es domingo):");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Carnet vigente S/N");
string carnet = Console.ReadLine().ToUpper();
Console.WriteLine("Trea autorixacion");
string autorizacion = Console.ReadLine().ToUpper();
Console.WriteLine("Trae USB? S/N");
string usb = Console.ReadLine().ToUpper();
Console.WriteLine("Esta unido? S/N");
string unido = Console.ReadLine().ToUpper();

if (rol < 1 || rol > 4)
{
    Console.WriteLine("Error: Rol fuera de rango (1-4).");
    return;
}
else if (hora < 0 || hora >= 23)
{
    Console.WriteLine("Error: Hora fuera de rango (0–<23).");
    return;
}
else if (dia < 1 || dia > 7)
{
    Console.WriteLine("Error: Día fuera de rango (1-7).");
    return;
}
else if (carnet != "S" && carnet != "N")
{
    Console.WriteLine("Error: Carnet vigente debe ser S o N.");
    return;
}
else if (autorizacion != "S" && autorizacion != "N")
{
    Console.WriteLine("Error: Autorización escrita debe ser S o N.");
    return;
}
else if (usb != "S" && usb != "N")
{
    Console.WriteLine("Error: Trae USB debe ser S o N.");
    return;
}
else if (unido != "S" && unido != "N")
{
    Console.WriteLine("Error: Acompañamiento debe ser S o N.");
    return;
}