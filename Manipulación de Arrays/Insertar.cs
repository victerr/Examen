 public void Insertar(Material mat, int posicion)
{
    for (int i = numMateriales; i > posicion; i--)
    {
        listaMateriales[i] = listaMateriales[i - 1];
    }
    listaMateriales[posicion] = mat;
    numMateriales++;
}