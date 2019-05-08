string nombreArchivo;
string linea;
StreamReader fichero;

Console.Write("Nombre del fichero: ");
nombreArchivo = Console.ReadLine();


fichero = File.OpenText(@nombreArchivo);
do
{
    linea = fichero.ReadLine();
    if (linea != null)
        Console.WriteLine(linea);
}
while (linea != null);