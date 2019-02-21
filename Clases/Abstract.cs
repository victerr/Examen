//No se pueden instanciar(crear objetos de esta clase)

abstract class Animal
{
	string nombre;
	
	public Animal(string nombre) //Las clases hijas pueden usar su método usando base, como si fuese una clase normal
	{
		this.nombre = nombre;
	}
	
		public abstract void Hablar(); //Debe implementarse siempre este método en las clases que hereden usando override
}

//Aunque no se puede instanciar, se puede crear un array de esta clase y rellenarlo con objetos de las clases hijas. Ejemplo:
	Animal[] animales = newAnimal[5];
	animales[0] = newPerro("Bobby");
	animales[1] = newPato("Donald");