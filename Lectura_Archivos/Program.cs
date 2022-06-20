// See https://aka.ms/new-console-template for more information
using System.IO;

//string guardado = @"C:\Repos\tp08-2022-Agustin978\Lectura_Archivos\documento\index.csv";
/*
enum FileMode
{
    CreateNew,
    Create,
    Open,
    OpenOrCreate,
    Truncate,
    Append
}*/
main();
/*
if(!File.Exists(guardado))
{
    FileStream fs = File.Create(guardado);
}
*/

void main()
{
    string carpeta = @"C:\Users\Agustin\Downloads";
    
    try
    {
        string[] carpetas = Directory.GetFiles(carpeta);
        string nombreArchivo = @"C:\Cursos\Programacion_en_C_UNT\Taller_de_Lenguajes\tp08-2022-Agustin978\Lectura_Archivos\Carpetas";
        string formato = ".csv";
        guardaArchivo(nombreArchivo, formato, carpetas);
        muestra(nombreArchivo, formato);
    }
    catch (System.IO.DirectoryNotFoundException)
    {
        Console.WriteLine("Error en la lectura del archivo :V");
    }
}

void guardaArchivo(string nombreArchivo, string formato, string[] carpetas)
{
    FileStream miArchivo = new FileStream(nombreArchivo+formato, System.IO.FileMode.OpenOrCreate);
    using(StreamWriter strWriter = new StreamWriter(miArchivo))
    {
        foreach(var carpeta in carpetas)
        {
            strWriter.WriteLine(carpeta);
            /*
            foreach(var elemento in carpeta.Split(@"\"))
            {
                strWriter.WriteLine($"{elemento}");
            }*/
        }
    }
}

//Muestra las carpetas de descargas
void muestra(string nombreArchivo, string formato)
{
    string line = "";
    FileStream miArchivo = new FileStream(nombreArchivo+formato, FileMode.Open);
    using(StreamReader stReader = new StreamReader(miArchivo))
    {
        while((line = stReader.ReadLine()) != null)
        {
            Console.WriteLine($"{line}\n");
        }
    }
}