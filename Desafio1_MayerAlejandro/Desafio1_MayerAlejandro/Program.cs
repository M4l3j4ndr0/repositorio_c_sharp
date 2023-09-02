// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Ingrese su dni: ");
string dni = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
string edad_text = Console.ReadLine();
int edad = int.Parse(edad_text);

Console.WriteLine("Ingrese su altura, en metros: ");
string altura = Console.ReadLine();

Console.WriteLine($"Bienvenido {nombre} {apellido} con numero de documento {dni} y con {edad} anios de edad y una altura de {altura} metros   ");