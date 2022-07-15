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


function listarTipoMedicamento() {
    objGlobalTipoMedicamento = {

        /*URL para listar data desde el controlador*/
        url: "Financiero/ListarIngresos",
        /*Cabeceras Tabla*/
        cabeceras: ["Id", "Clasificador", "Fuente Especifica", "Organismo Financamiento", "Institucion Otorgante", "Tipo", "Año Anterior", "Fecha", "Estimado","Formulado"],
        /*Propiedades del servicio*/
        propiedades: ["Id", "clasificador", "fuenteEspecifica", "organismoFinancamiento", "institucionOtorgante", "tipo", "anoAnterior", "fecha", "estimado", "formulado"],
        editar: false,
        eliminar: false,
        propiedadId: "id",
        divPintado: "pruebaContenedor",
        divContenedorTabla: "LaTabla",
        idtabla: "tablaklk",
        urleliminar: "TipoMedicamento/eliminarTipoMedicamento",
        nombreparametroeliminar: "id",
        titlePopup: "Presupuesto de ingresos",
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
                    label: "Clasificador",
                    readonly: true,

                    //nuevas


                    //
                    class: "col-md-6",
                    name: "iidmedicamento"
                },
            ],

            [
                {
                    //div
                    class: "col-md-6",
                    label: "Denominacion",
                    name: "iidtipomedicamento",

                    data: "hola",
                    id: "cboTipoMedicamentoFormulario",
                    propiedadmostrar: "nombre",
                    valuemostrar: "idtipomedicamento"

                },
                {
                    label: "Fuente Financiamiento",

                    class: "col-md-6",
                    name: "usomedicamento"
                },
                {
                    label: "Fuente Especifica",

                    class: "col-md-6",
                    name: "usomedicamento",

                    id: "cboLaboratorioFormulario",

                },
                {
                    label: "Organismo Financamiento",

                    class: "col-md-6",
                    name: "contenido"
                },

            ],
            [
                
                {
                    label: "Institucion Otorgante",

                    class: "col-md-6",
                    name: "contenido"
                },
                {
                    label: "Tipo",

                    class: "col-md-6",
                    name: "contenido"
                },
                {
                    label: "Año Anterior",

                    class: "col-md-6",
                    name: "contenido"
                },
                {
                    label: "Fecha",

                    class: "col-md-6",
                    name: "contenido"
                },
                {
                    label: "Estimado",

                    class: "col-md-6",
                    name: "contenido"
                },
                {
                    label: "Formulado",

                    class: "col-md-6",
                    name: "contenido"
                },
            ]

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
                    class: "col-md-2",
                    label: "clasificador",
                    name: "Codigo"

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
