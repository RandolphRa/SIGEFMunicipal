//generico get
async function fetchGet(url, tipoRespuesta, callBack) {

        var raiz = document.getElementById("hdfOculto").value;
        var urlCompleta = `${window.location.protocol}//${window.location.host}/${raiz}${url}`
        var res = await fetch(urlCompleta)

        if (tipoRespuesta == "json") {
            res = await res.json();
        }
        else if (tipoRespuesta == "text") {
            res = await res.text();
        }

        callBack(res) 
}

//generico creacion de tabla
var ObjConfiguracionGobal;
function AgregarTabla(objConfiguration) {
    ObjConfiguracionGobal = objConfiguration;
    fetchGet(objConfiguration.url, "json", function (res) {
        var contenido = "";
        contenido += "<div id='divContenedorTabla'>";
        contenido += GenerarTabla(res);
        contenido += "</div>";
        document.getElementById(objConfiguration.NameElement).innerHTML = contenido;

    })
}

function GenerarTabla(res) {
    var contenido = "";

    //propiedades gobales
    var cabeceras = ObjConfiguracionGobal.cabeceras;
    var propiedades = ObjConfiguracionGobal.propiedades;
    //propiedades gobales

    contenido += "<table class='table'>";
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < cabeceras.length; i++) {
        contenido += `<td>${cabeceras[i]}</td>`;
    }
    contenido += "</tr>";
    contenido += "</thead>";

    var nRegistros = res.length;
    var obj;
    var propiedadActual;
    contenido += "<tbody>";
    contenido += "<tr>";
    for (var i = 0; i < nRegistros; i++) {
        obj = res[i];
        for (var j = 0; j < propiedades.length; j++) {
            propiedadActual = propiedades[j]
            contenido += `<td>${obj[propiedadActual]}</td>`
        }
        contenido += "</tr>";
    }
  
    contenido += "</tbody>";
    contenido += "</table>";

    return contenido;
}


//Ejemplo de llamada 

//GenerarTabla({
//    url: "NombreControlador/EndPoint",
//    cabecera: ["Nombre1", "Nombre2", "Nombre3"],
//    propiedades: ["Id", "Descripcion", "Cantidad"],
//    NameElement: "tableId"
//})



