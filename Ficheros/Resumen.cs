//////////Escribir en un fichero de texto
////Declaraciones
StreamWriter fichero;

////Usos
fichero =File.CreateText("prueba.txt"); //Sobrescribe el fichero
fichero =File.AppendText("prueba.txt"); //Añade al final del fichero
StreamWriter fichero = new StreamWriter("prueba2.txt",false) //Sobrescribe el fichero
StreamWriter fichero = new StreamWriter("prueba2.txt",false) //Añade al final del fichero
File.WriteAllLines("ejemplo.txt",frases);//Escribe todas las líneas en un fichero. frases es un array. Sin declaracion de StreamWriter

//////////Leer de un fichero de texto
////Declaraciones
StreamReader fichero;

//Usos
string[]contenido = File.ReadAllLines("ejemplo.txt"); //Lee todas las líneas en un fichero.
fichero =File.OpenText("prueba.txt");  //Abre el fichero de texto para lectura
fichero = new StreamReader("prueba.txt"); //Abre el fichero de texto para lectura

//////////Leer de un fichero binario
////Declaraciones
FileStream fichero; //Para leer byte a byte
BinaryReader fichero; //Para leer datos nativos(short,int, float, etc)

//Usos
fichero =File.OpenRead(nombre); //Abre el fichero binario para lectura
unDato =(byte)fichero.ReadByte(); //Lee un byte del fichero binario
newFileStream(nombre,FileMode.Open); //Otros FileMode son Append, Create, CreateNew, OpenOrCreate
fichero =newBinaryReader(File.Open(nombre,FileMode.Open); //Como arriba


//////////Escribir en un fichero binario
////Declaraciones
FileStream ficheroEscritura;
BinaryWriter fichero;

//Usos
ficheroEscritura = File.Create(nombreFichero + ".out");
fichero = new BinaryWriter(File.Open(nombre,FileMode.Create)); //Otros FileMode son Append, Create, CreateNew, OpenOrCreate


//Otros
if(File.Exists(nombre) //Saber si un fichero existe
SeekOrigin.Begin; //Posiciona la lectura en el inicio. Sirve con Current y End
ficheroEntrada.BaseStream.Seek(1,SeekOrigin.Begin); //Como el de arriba pero para BinaryReader