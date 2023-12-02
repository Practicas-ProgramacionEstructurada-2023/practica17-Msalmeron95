using System;
using System.IO;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opciones;

            do
            {
                Console.WriteLine("\n Menú:");
                Console.WriteLine("1. Buscar y mostrar el contenio de un archivo");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opcion (1 - 2): ");

                opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        ShowFileContent();
                        break;

                    case 2:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpcion no valida. Intente de nuevo.");
                        break;
                }
                
                } while (opciones != 2);
        }//Fin del Main

        static void ShowFileContent()
        {
            Console.Write("\nIngrese la ruta del archivo: ");
            string? filePath = Console.ReadLine();

            if(File.Exists(filePath))
            {
                string content = ReadFileContent(filePath);
                Console.WriteLine($"\nContenido del archivo \"{filePath}\":\n{content}");
            }
            else
            {
              Console.WriteLine("El archivo no existe en la ruta proporcionada");  
            }


            static string ReadFileContent(string filePath)
            {
                try
                {
                    string content = File.ReadAllText(filePath);
                    return content;
                }

                catch (Exception ex)
                {
                    return $"Error al leer el archivo: {ex.Message}";
                }
            }
        }
    }
}