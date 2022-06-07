// See https://aka.ms/new-console-template for more information
using System.IO;

//string guardado = @"C:\Repos\tp08-2022-Agustin978\Lectura_Archivos\documento\index.csv";
string carpeta = @"C:\Users\Alumno\Downloads";
/*
if(!File.Exists(guardado))
{
    FileStream fs = File.Create(guardado);
}
*/

try
{
    string[] carpetas = Directory.GetFiles(carpeta);
    muestra(carpetas);
}
catch (System.IO.DirectoryNotFoundException)
{
    Console.WriteLine("Error en la lectura del archivo :V");
}


void muestra(string[] carpetas)
{
    foreach(var archivo in carpetas)
    {
        Console.WriteLine(archivo+"\n");
    }
}

void carga(string[] carpetas)
{
    string guardado = @"C:\Repos\tp08-2022-Agustin978\Lectura_Archivos\documento\index.csv", separador = ",";
    if(!File.Exists(guardado))
    {
        FileStream fs = File.Create(guardado);
    }

    using(var filestream = new FileStream(guardado, FileMode.Append))
    {
        foreach(var archivo in carpetas)
        {
            filestream.Write(archivo);
        }
    }
}
