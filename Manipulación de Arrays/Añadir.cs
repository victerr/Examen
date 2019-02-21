public void Add(Material material)
{
    if(numMateriales< MAX_MAT)
    {
        listaMateriales[numMateriales] = material;
        numMateriales++;
    }
}