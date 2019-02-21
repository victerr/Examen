 public void Borrar(int posicion)
{
    if(posicion>0 && posicion < numMateriales)
    {
        posicion--;
        for (int i = posicion; i < numMateriales - 1; i++)
        {
            listaMateriales[i] = listaMateriales[i + 1];
        }

        numMateriales--;
    }
}