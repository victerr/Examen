for (int i=0;i<cantidad-1;i++)
{
	for (int j=i+1;j<cantidad;j++)
	{
		if (peliculas[i].titulo.CompareTo(peliculas[j].titulo)>0)
		{
			peliculaAux.titulo=peliculas[i].titulo;
			peliculas[i].titulo=peliculas[j].titulo;
			peliculas[j].titulo=peliculaAux.titulo;
		}
							
	}
}
