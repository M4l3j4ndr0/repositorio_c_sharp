// Actividad 1 - Clase 1
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

Console.WriteLine("Ingrese su apodo: ");
string apodo = Console.ReadLine();

Console.WriteLine($"Bienvenido {nombre} {apellido} con numero de documento {dni} y con {edad} anios de edad y una altura de {altura} metros   ");

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------- ");

//Actividad 2 - Clase 1
Console.WriteLine("Ingrese el número A: ");
int numero_a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número B: ");
int numero_b = int.Parse(Console.ReadLine());

int suma_ab = numero_a + numero_b;

Console.WriteLine($"Los numeros ingresados son {numero_a} & {numero_b} y su suma es: {suma_ab} ");

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------- ");

//Actividad 3 - Claase 1

string nombre_codigo = nombre + '"' + apodo + '"' + apellido;

Console.WriteLine($"Su nombre secreto es {nombre_codigo}");