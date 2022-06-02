window.onload = function () {
    listarTipoMedicamento();
/*    listarTipoMedicamento2();*/
}


var objGlobalTipoMedicamento;
var objFormularioTipoMedicamento;
var bjFormularioMedicamento;
var objBusqueda;

function filtrarTipoMedicamento() {
    var nombre = get("txtnombrebusqueda")
    if (nombre == "") {
        listarTipoMedicamento();
    } else {
        //objGlobalTipoMedicamento.url = "TipoMedicamento/filtrarTipoMedicamento/?nombretipo=" + nombre
        //pintar(objGlobalTipoMedicamento);
        var urlBuscar = "TipoMedicamento/filtrarTipoMedicamento/?nombretipo=" + nombre
        fetchGet(urlBuscar, "json", function (res) {
            document.getElementById(objGlobalTipoMedicamento.divContenedorTabla).innerHTML = generarTabla(res);
            $("#" + objGlobalTipoMedicamento.idtabla).DataTable();

        })
    }
}

ID = 1,
    CLASIFICADOR = 1234,
    DESCRIPCION = "Descripcion algo",
    CUENTA_CONTROL = 23123,
    TIPO = "NORMAL",
    CLASIFICACION = "UNA CLASIFICACION",
    CTA_CONTABLE = 123123


function listarTipoMedicamento() {
    objGlobalTipoMedicamento = {
      
        /*URL para listar data desde el controlador*/
        url: "Financiero/ListarFuentes",
        /*Cabeceras Tabla*/
        cabeceras: ["id","Grupo", "Fuente", "Fondo", "Denominacion"],
        /*Propiedades del servicio*/
        propiedades: ["id", "grupo","fuente", "fondo", "denominacion"],
        editar: false,
        eliminar: false,
        propiedadId: "id",
        divPintado: "pruebaContenedor",
        divContenedorTabla: "LaTabla",
        idtabla:"tablaklk",
        urleliminar: "TipoMedicamento/eliminarTipoMedicamento",
        nombreparametroeliminar: "id",
        titlePopup: "Formulario de Clasificadores Contables",
        paginar: false
    }

    bjFormularioMedicamento = {
        type: "popup",
        legend: "",
        idformulario: "frmRegistroMedicamento",
        urlguardar: "Medicamento/guardarMedicamento",
        urlrecuperar: "Medicamento/recuperarMedicamento",
        parametrorecuperar: "iidmedicamento",
        
        formulario: [
            [
                {
                    label: "Codigo",
                    readonly: true,
                 
                    name: "iidmedicamento"
                },
            ],
            
            [
                {
                    //div
                    class: "col-md-6",
                    label: "Fondo",
                    name: "iidtipomedicamento",
                    
                    data: "hola",
                    id: "cboTipoMedicamentoFormulario",
                    propiedadmostrar: "nombre",
                    valuemostrar: "idtipomedicamento"

                },
                {
                    label: "Fuente",

                    class: "col-md-6",
                    name: "usomedicamento"
                },
                {
                    label: "Origen",

                    class: "col-md-6",
                    name: "usomedicamento",
                   
                },
                {
                    label: "Denominacion",

                    class: "col-md-6",
                    name: "usomedicamento"
                }
            ],
        

        ]
    }

    objBusqueda = {
        legend: "",
        idformulario: "frmBusqueda",
        url: "Laboratorio/filtrarLaboratorio",
        formulario: [

            [
                {
                    //div
                    class: "col-md-4",
                    label: "Codigo",
                    name: "Descripcion"

                },
           

            ]
        ]
    }
    pintar(objGlobalTipoMedicamento, objBusqueda, bjFormularioMedicamento)

}
//function listarTipoMedicamento2() {
//    objGlobalTipoMedicamento1 = {
//        url: "Home/ListarUsuario",
//        cabeceras: ["ID", "Nombre"],
//        propiedades: ["id", "name"],
//        editar: true,
//        eliminar: true,
//        propiedadId: "id",
//        divPintado: "pruebaContenedor2",
//        divContenedorTabla: "LaTabla2",
//        urleliminar: "TipoMedicamento/eliminarTipoMedicamento",
//        nombreparametroeliminar: "id",
//        paginar: false
//    }

//    objFormularioTipoMedicamento1 = {
//        type: "fieldset",
//        legend: "Campos pruebas",
//        idformulario: "frmGuardarTipoMedicamento",
//        urlguardar: "TipoMedicamento/GuardarDatos",
//        urlrecuperar: "TipoMedicamento/recuperarTipomedicamento",
//        parametrorecuperar: "iidtipomedicamento",
//        pos: "bottom",
//        posid: "divBusquedaForm",
//        formulario: [
//            [
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true

//                },
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true

//                },
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true

//                },
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true

//                },
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true

//                },
//                {
//                    class: "col-md-6",
//                    label: "Id tipo medicamento",
//                    name: "idtipomedicamento",
//                    readonly: true


//                },
//                {
//                    class: "col-md-6",
//                    label: "Nombre",
//                    name: "nombre",
//                    classControl: "ob max-100 min-3 sl"
//                }
//            ],
//            [
//                {
//                    class: "col-md-12",
//                    type: "textarea",
//                    label: "Descripciòn",
//                    name: "descripcion",
//                    classControl: "ob max-200 min-5 slcenb"
//                }
//            ]

//        ]
//    }
//    pintar(objGlobalTipoMedicamento1, BuscarDatosGenericoBusqueda, bjFormularioMedicamento)

//}


function Listar() {
    AgregarTabla({
        url: "Home/ListarUser",
        cabeceras: ["ID", "Nombre"],
        propiedades: ["id", "name"],
        NameElement: "tableId"
    })
}
