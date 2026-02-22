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
Console.WriteLine("Trae autorizacion?");
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

int acceso = 0;              
string nivel = "N/A";

int esLaboral = (dia >= 1 && dia <= 5) ? 1 : 0;         
int horarioEstudiante = (hora >= 7.0 && hora <= 18.0) ? 1 : 0; 
int horarioGeneral = (hora >= 7.0 && hora <= 20.0) ? 1 : 0;    

switch (rol)
{
    case 1: // Estudiante
        if (carnet == "S" && esLaboral == 1 && horarioEstudiante == 1)
        {
            acceso = 1;
            nivel = "Básico";
        }
        else
        {
            acceso = 0;
        }
        break;

    case 2: // Docente
        if (carnet == "S")
        {
            if (esLaboral == 1 && horarioGeneral == 1)
            {
                acceso = 1;
                nivel = "Medio";
            }
            else
            {
                if (autorizacion == "S")
                {
                    acceso = 1;
                    nivel = "Medio (fuera de horario autorizado)";
                }
                else
                {
                    acceso = 0;
                }
            }
        }
        break;

    case 3: // Técnico IT
        if (carnet == "S")
        {
            if (horarioGeneral == 1)
            {
                acceso = 1;
                nivel = "Alto";
            }
            else
            {
                if (autorizacion == "S")
                {
                    acceso = 1;
                    nivel = "Alto (fuera de horario autorizado)";
                }
                else
                {
                    acceso = 0;
                }
            }
        }
        break;

    case 4: // Visitante
        if (autorizacion == "S" && unido == "S")
        {
            acceso = 1;
            nivel = "Visitante";
        }
        else
        {
            acceso = 0;
        }
        break;
        // default: no es necesario por la validación previa de rol (1-4)
}
// "USB solo permitido si autorización y acompañamiento"
if (acceso == 1 && usb == "S")
{
    if (!(autorizacion == "S" && unido == "S"))
    {
        acceso = 0;
    }
}
