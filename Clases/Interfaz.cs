interface IFiguraGeometrica{ //NO tiene modificador de accesibilidad(public, private, protected)
	doubleCalcularArea(); //Cualquier clase que implemente este interfaz debe implementar sus métodos
	doubleCalcularPerimetro();
	}

//Aunque no se puede instanciar, se puede crear un array de esta clase y rellenarlo con objetos de las clases hijas. Ejemplo:	
	IFiguraGeometrica[] figuras = newIFiguraGeometrica[10];
	figuras[0] = newCuadrado(3);
	figuras[1] = newCirculo(2.5);