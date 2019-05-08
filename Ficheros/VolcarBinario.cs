			FileStream ficheroLectura;
            Console.Write("Nombre del fichero: ");
            string nombreFichero = Console.ReadLine();

            try
            {
                ficheroLectura = File.OpenRead(nombreFichero);
                byte[] datos = new byte[ficheroLectura.Length];
                int amountToRead = (int)ficheroLectura.Length;
                double amountRead = ficheroLectura.Read(datos, 0, amountToRead);
				
                if (amountRead < amountToRead)
                {
                    Console.WriteLine("No se han podido leer todos los datos.");
                }
                else
                {
                    FileStream ficheroEscritura = File.Create(nombreFichero + ".out");

                    ficheroEscritura.Write(datos, 0, amountToRead);

                    ficheroEscritura.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Write(e.Message);
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
            }