#pragma checksum "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee00003eeaa46e72f3c58040f4160168dd51eaf4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_III______.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Tarea_III______;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\_Imports.razor"
using Tarea_III______.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio3")]
    public partial class Ejercicio_3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ejercicio_3</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h6>Programa que acepte una palabra o frase en espaniol, mostrarla en ingles. </h6>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control form-control-lg");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "placeholder", "Inserte una frase ");
            __builder.AddAttribute(6, "aria-label", ".form-control-lg example");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
                    frase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => frase = __value, frase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success form-control form-control-lg");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
                                                                                     traducirr

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Traducir");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\n<br>");
#nullable restore
#line 22 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
 if (frase != null)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card mb-12 shadow-lg p-3 mb-5 bg-white rounded");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row g-0");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-12");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "h4");
            __builder.AddContent(25, 
#nullable restore
#line 29 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
                      Frasetraducida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\rrody\Documents\Todo documentos\PROGRAMACION\Programacion III\Tarea 3\Tarea III -----\Pages\Ejercicio 3.razor"
       

        static string frase = "";
        string Frasetraducida;

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ResponseData
    {
        public string translatedText { get; set; }
        public double match { get; set; }
    }

    public class Match
    {
        public string id { get; set; }
        public string segment { get; set; }
        public string translation { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string quality { get; set; }
        public object reference { get; set; }
        [JsonProperty("usage-count")]
        public int UsageCount { get; set; }
        public string subject { get; set; }
        [JsonProperty("created-by")]
        public string CreatedBy { get; set; }
        [JsonProperty("last-updated-by")]
        public string LastUpdatedBy { get; set; }
        [JsonProperty("create-date")]
        public string CreateDate { get; set; }
        [JsonProperty("last-update-date")]
        public string LastUpdateDate { get; set; }
        public double match { get; set; }
    }

    public class Root
    {
        public ResponseData responseData { get; set; }
        public bool quotaFinished { get; set; }
        public object mtLangSupported { get; set; }
        public string responseDetails { get; set; }
        public int responseStatus { get; set; }
        public string responderId { get; set; }
        public object exception_code { get; set; }
        public List<Match> matches { get; set; }
    }


    Root traductor;

    async Task traducirr()
    {
        var Api = "https://api.mymemory.translated.net/get?q=" + frase + "!&langpair=es|en";
        WebClient web = new WebClient();
        var dt = web.DownloadString(Api);
        traductor = JsonConvert.DeserializeObject<Root>(dt);

        Frasetraducida = traductor.responseData.translatedText;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
