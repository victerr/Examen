public static int Main(string[]args)
{
	Console.WriteLine("Parámetros: {0}",args.Length);
	
	for(inti =0;i <args.Length;i++) //Así se recorren los args que se pasan al programa. Es como un array normal. Los recogeremos como sea necesario.
	{
		Console.WriteLine("El parámetro {0} es: {1}",i,args[i]);
	}
	if(args.Length ==0) //Si no hay args, da error
	{
		Console.WriteLine("No ha indicado ningún parámetro!");
		
	}
	return 0;
}