try
{
    ficheroLectura = File.OpenRead(nombreFichero);
    byte[] datos = new byte[ficheroLectura.Length];
    int amountToRead = (int)ficheroLectura.Length;
    double amountRead = ficheroLectura.Read(datos, 0, amountToRead);
	
    if (amountRead < amountToRead)
    {
        Console.WriteLine("No se han podido leer todos los datos.");
    }
    else
    {
        //Hacer lo que sea con los datos leídos. Están en el array "datos"
    }
}
catch (FileNotFoundException e)
{
    Console.Write(e.Message);
}
catch (IOException e)
{
    Console.Write(e.Message);
}