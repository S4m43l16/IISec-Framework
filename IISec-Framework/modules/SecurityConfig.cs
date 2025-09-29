using System;
using System.IO;
using System.Collections.Generic;

namespace IISec_Framework.SecurityConfig;

public class SecurityConfig
{
    // funcion que sobreescribe el archivo web.config con las configuraciones de seguridad recomendadas por Microsoft
    // falta definir las configuraciones que se van a agregar al archivo web.config
    // y generar la plantilla del archivo web.config que se retornara a dataMaker
    public static void OverwriteWebConfig(string choice)
    {
        using (StreamWriter writer = new StreamWriter(choice + "/web.config"))
        {
            writer.WriteLine("<configuration>");
            writer.WriteLine("  <system.webServer>");
            writer.WriteLine("    <security>");
            writer.WriteLine("      <requestFiltering>");
            writer.WriteLine("        <hiddenSegments>");
            writer.WriteLine("          <add segment=\"bin\" />");
            writer.WriteLine("          <add segment=\"App_Data\" />");
            writer.WriteLine("          <add segment=\"App_Code\" />");
            writer.WriteLine("          <add segment=\"App_GlobalResources\" />");
            writer.WriteLine("          <add segment=\"App_LocalResources\" />");
            writer.WriteLine("          <add segment=\"App_WebReferences\" />");
            writer.WriteLine("          <add segment=\"aspnet_client\" />");
            writer.WriteLine("        </hiddenSegments>");
            writer.WriteLine("      </requestFiltering>");
            writer.WriteLine("    </security>");
            writer.WriteLine("  </system.webServer>");
            writer.WriteLine("</configuration>");
        }
    }
}