public static void Duplicar(ref int x) 
{
	Console.WriteLine("  El valor recibido vale {0}",x);
	x =x *2;
	Console.WriteLine("  y ahora vale {0}",x);
}

//En esta función el valor se "devolverá" a través de la propia variable "x" que se le pasa por parámetro.
//Eso significa que el valor modificado estará en el parámetro de origen que llama la función. Ejemplo

int numero=2;
Duplicar(numero);

//El número duplicado estaría en "número"