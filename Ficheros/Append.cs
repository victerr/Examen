			StreamWriter fichero;

            fichero = File.AppendText(@"..\..\..\EjFicheros2\bin\Debug\textFile2.txt");

            
            fichero.WriteLine(linea);
            

            fichero.Close();