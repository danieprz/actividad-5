// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, introduzca su nombre a continuación por favor.");
var nombre = Console.ReadLine();
Console.Write("Un placer,");
for (int i = (nombre.Length-1); i >= 0; i--)
{
    Console.Write(nombre[i]);
}
