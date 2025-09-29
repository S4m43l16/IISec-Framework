using System;
using System.IO;

namespace IISec_Framework.SearchWebConfig;

public class WebConfigSearch
{
    public static bool Search(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            path = ".";
        }
        var files = Directory.GetFiles(path, "web.config");
        foreach (var file in files)
        {
            if (file != string.Empty)
            {
                return true;
            }
        }
        return false;
    }
}