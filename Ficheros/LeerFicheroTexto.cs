public static void Main()
{
	StreamReader fichero;
	string linea;
	fichero =File.OpenText("prueba.txt");
	linea =fichero.ReadLine();
    while(linea !=null){
		Console.WriteLine(linea);
		linea =fichero.ReadLine();
	}
	
	fichero.Close()
}