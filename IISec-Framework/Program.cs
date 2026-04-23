using System;
using System.IO;
using System.Collections.Generic;

using IISec_Framework.SearchWebConfig;


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
        }

        else if(WebConfigSearch.Search(choice) == false){
            
        }
        else
        {
            Console.WriteLine("web.config file not found in the current directory.");
        }
    }
}