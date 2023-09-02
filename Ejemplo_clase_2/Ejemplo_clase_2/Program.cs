
/*
 //Actividad 1
Console.WriteLine("Ingrese el nombre completo del alumno:");
string alumno = Console.ReadLine();

Console.WriteLine("Ingrese la comision del alumno:");
string comision = Console.ReadLine();

Console.WriteLine("Ingrese la nota del alumno:");
int nota = int.Parse(Console.ReadLine());

switch (comision)
{
    case "A":
        Console.WriteLine($"El alumno {alumno} pertenece al turno mañana");
        break;
    case "B":
        Console.WriteLine($"El alumno {alumno} pertenece al turno tarde");
        break;
    case "C":
        Console.WriteLine($"El alumno {alumno} pertenece al turno noche");
        break;
}
if (comision != "A" && comision != "B" && comision != "C"  )

{
    Console.WriteLine($"El alumno {alumno} no pertenece a ninguna comision o el tipo de comisión ingresado no es válido");
}

if (0 > nota || nota > 10)
{
    Console.WriteLine($"La nota ingresada es  ingresado no es válida");
}
else
{
    if (nota >=7)
    {
        Console.WriteLine($"Promociona la materia con una nota de {nota}");
    }
    else
    {
        if (nota >=4 && nota <7)
        {
            Console.WriteLine($"Aprueba la cursada de la materia con una nota de {nota}");
        }
        else
        {
            Console.WriteLine($"Recursa la materia con una nota de {nota}");
        }    
    }
}
*/
//Actividaad 2
int contrasenia = 123456;
string perfil;
Console.WriteLine("Ingrese su contraseña:");
int log_in = int.Parse(Console.ReadLine());
if (log_in == contrasenia)
{
    Console.WriteLine("Bienvenido usuario! Por favor indique su perfil");
    perfil = Console.ReadLine();
    switch (perfil)
    {
        case "U":
            Console.WriteLine($"Su perfil es de Administrador");
            break;
        case "A":
            Console.WriteLine($"Su perfil es de Usuario");
            break;
        case "X":
            Console.WriteLine($"Su perfil es no definido");
            break;
    }
    if (perfil != "U" && perfil != "A" && perfil != "X")

    {
        Console.WriteLine($"El valor ingresado no es válido");
    }
}
else
{
    Console.WriteLine("Ingreso erroneo. Re-ingrese su contraseña:");
    log_in = int.Parse(Console.ReadLine());
    if (log_in != contrasenia)
    {
        Console.WriteLine("Ingreso erroneo. Reinicie el programa");
    }
    else
    {
        Console.WriteLine("Bienvenido usuario! Por favor indique su perfil");
        perfil = Console.ReadLine();
        switch (perfil)
        {
            case "U":
                Console.WriteLine($"Su perfil es de Administrador");
                break;
            case "A":
                Console.WriteLine($"Su perfil es de Usuario");
                break;
            case "X":
                Console.WriteLine($"Su perfil es no definido");
                break;
        }
        if (perfil != "U" && perfil != "A" && perfil != "X")

        {
            Console.WriteLine($"El valor ingresado no es válido");
        }
    }
}
