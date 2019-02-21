bool salir=false;
string opcion="";

do
{
	Console.WriteLine("1.- ");
	Console.WriteLine("2.- ");
	Console.WriteLine("3.- ");
	Console.WriteLine("4.- ");
	Console.WriteLine("T.- Terminar");
	Console.WriteLine();
	Console.Write("Opción: ");
	opcion=Console.ReadLine();
	
	switch (opcion)
	{
		case "1":
		
		
		break;
		case "2":
		
		
		break;                                 
		case "3":
			
			
		break;
		case "4":
		
		break;
		
		case "T":
		case "t":
			salir=true;
		break;
	}
}
while (!salir);