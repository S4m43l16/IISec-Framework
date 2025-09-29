using System;
using System.IO;
using System.Collections.Generic;

using IISec_Framework.SearchWebConfig;
using IISec_Framework.DataMake;

namespace IISec_Framework;

public class Framework
{
    public static void Main(string[] args)
    {
        Console.WriteLine("IISecFramework");

        Console.WriteLine("Por favor indica una ruta o deja en blanco para la ruta actual:");
        string choice = Console.ReadLine();

        if (WebConfigSearch.Search(choice) == true)
        {
            if (string.IsNullOrEmpty(choice))
            {
                choice = ".";
            }
            Console.WriteLine("Se ha encontrado un archivo web.config en la ruta indicada. \nMostrando contenido:");

            for (int i = 0; i < dataProcess.Readfile(choice).Count; i++)
            {
                Console.WriteLine(dataProcess.Readfile(choice)[i]);
            }
            Console.WriteLine("\n¿Desea sobre escribirlo?");
            string response = Console.ReadLine();

            if (response.ToLower() == "si" || response.ToLower() == "s")
            {
                // llamar a la funcion que sobreescribe el archivo web.config
                // Aun falta crear la clase, el metodo y la logica para sobreescribir el archivo
                Console.WriteLine("El archivo web.config ha sido sobrescrito.");
            }
            else
            {
                Console.WriteLine("No se ha realizado ningun cambio en el archivo web.config.");
            }
        }
        else
        {
            Console.WriteLine("web.config file not found in the current directory.");
        }
    }
}