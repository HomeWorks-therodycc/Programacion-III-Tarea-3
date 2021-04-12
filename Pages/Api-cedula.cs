// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class RootCedula
{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string FechaNacimiento { get; set; }
    public bool ok { get; set; }
    public string foto { get; set; }
}


