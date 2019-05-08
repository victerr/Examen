			FileStream ficheroLectura;
            
            string origen = args[0];
            string destino = args[1];

            try
            {
                ficheroLectura = File.OpenRead(origen);
                byte[] datos = new byte[ficheroLectura.Length];
                int amountToRead = (int)ficheroLectura.Length;
                double amountRead = ficheroLectura.Read(datos, 0, amountToRead);
                if (amountRead < amountToRead)
                {
                    Console.WriteLine("No se han podido leer todos los datos.");
                }
                else
                {
                    if (File.Exists(destino))
                    {
                        Console.Write("Se ha sobrescrito el fichero destino.");

                    }

                    BinaryWriter ficheroEscritura = new BinaryWriter(File.Open(destino,FileMode.Create));
                    
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