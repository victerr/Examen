public void Buscar(string descripcion)
{
    for (int i = 0; i < numMateriales-1; i++)
    {
        if (listaMateriales[i].GetDescripcion().Contains(descripcion))
        {
            Console.WriteLine(listaMateriales[i].GetDescripcion());
        }
    }
}