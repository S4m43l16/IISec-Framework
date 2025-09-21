using System;
using System.IO;

namespace SearchWebConfig;

public class SearchWebConfig
{
    public static bool Search(string path=".")
    {
        try
        {
            var files = Directory.GetFiles(path, "web.config");
            foreach (var file in files)
            {
                Console.WriteLine($"Ya hay un web.config existente");
            }
            return files.Length > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error searching for web.config files: {ex.Message}");
            return false;
        }
    }
}