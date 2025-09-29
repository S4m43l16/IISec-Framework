using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;

namespace IISec_Framework.DataMake;


public class dataProcess
{
    // funcion que lee el archivo, lee cada linea y retorna una lista con las lineas
    // si ocurre algun error al leer el archivo retorna el error y muestra un mensaje
    public static List<string> Readfile(string filePath)
    {
        List<string> dataLines = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath + "/web.config"))
            {
                while (!reader.EndOfStream)
                {
                    dataLines.Add(reader.ReadLine());
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Hubo un error al abir el archivo: {ex.Message}");
            Console.WriteLine("Cierra el archivo web.config e intenta nuevamente");
        }
        return dataLines;
    }

    // crear metodo que reciba la plantilla que va a retornar SecurityConfig
    // y sobreescriba el archivo web.config en caso de que exista
    // si no existe, crear el archivo web.config con la plantilla recibida desde SecurityConfig
    // retornar un mensaje de exito al finalizar la operacion
    // si ocurre algun error al escribir el archivo, retornar el error y mostrar un mensaje
}