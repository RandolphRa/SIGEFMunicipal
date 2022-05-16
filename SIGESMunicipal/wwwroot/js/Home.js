window.onload = function () {
    listarTipoMedicamento();
    listarTipoMedicamento2();
}


var objGlobalTipoMedicamento;
var objFormularioTipoMedicamento;
var bjFormularioMedicamento;


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
    objGlobalTipoMedicamento1 = {
        url: "Home/ListarUsuario",
        cabeceras: ["ID", "Nombre"],
        propiedades: ["id", "name"],
        editar: true,
        eliminar: true,
        propiedadId: "id",
        divPintado: "pruebaContenedor",
        divContenedorTabla:"LaTabla",
        urleliminar: "TipoMedicamento/eliminarTipoMedicamento",
        nombreparametroeliminar: "id",
        paginar: false
    }

    bjFormularioMedicamento = {
        type: "popup",
        legend: "Registro  Medicamento",
        idformulario: "frmRegistroMedicamento",
        urlguardar: "Medicamento/guardarMedicamento",
        urlrecuperar: "Medicamento/recuperarMedicamento",
        parametrorecuperar: "iidmedicamento",
        formulario: [
            [
                {
                    label: "Id Medicamento",
                    readonly: true,
                    class: "col-md-6",
                    name: "iidmedicamento"
                },
                {
                    label: "Codigo Medicamento",

                    class: "col-md-6",
                    name: "codigoMedicamento"
                }
            ],
            [
                {
                    label: "Nombre Medicamento",

                    class: "col-md-6",
                    name: "nombremedicamento"
                },
                {
                    //div
                    class: "col-md-6",
                    label: "Laboratorio",
                    name: "iidlaboratorio",
                    type: "combobox",
                    data: "hola",
                    id: "cboLaboratorioFormulario",
                    propiedadmostrar: "nombre",
                    valuemostrar: "iidlaboratorio"

                }
            ],
            [
                {
                    //div
                    class: "col-md-6",
                    label: " Tipo Medicamento",
                    name: "iidtipomedicamento",
                    type: "combobox",
                    data: "hola",
                    id: "cboTipoMedicamentoFormulario",
                    propiedadmostrar: "nombre",
                    valuemostrar: "idtipomedicamento"

                },
                {
                    label: "Uso Medicamento",

                    class: "col-md-6",
                    name: "usomedicamento"
                }
            ],
            [
                {
                    label: "Contenido",

                    class: "col-md-12",
                    name: "contenido"
                }
            ]

        ]
    }

    objFormularioTipoMedicamento1 = {
        type: "fieldset",
        legend: "Prueba 1",
        idformulario: "frmGuardarTipoMedicamento",
        urlguardar: "TipoMedicamento/GuardarDatos",
        urlrecuperar: "TipoMedicamento/recuperarTipomedicamento",
        parametrorecuperar: "iidtipomedicamento",
        pos: "bottom",
        posid: "divBusquedaForm",
        formulario: [
            [
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Nombre",
                    name: "nombre",
                    classControl: "ob max-100 min-3 sl"
                }
            ],
            [
                {
                    class: "col-md-12",
                    type: "textarea",
                    label: "Descripciòn",
                    name: "descripcion",
                    classControl: "ob max-200 min-5 slcenb"
                }
            ]

        ]
    }
    pintar(objGlobalTipoMedicamento1, objFormularioTipoMedicamento1, bjFormularioMedicamento)

}
function listarTipoMedicamento2() {
    objGlobalTipoMedicamento1 = {
        url: "Home/ListarUsuario",
        cabeceras: ["ID", "Nombre"],
        propiedades: ["id", "name"],
        editar: true,
        eliminar: true,
        propiedadId: "id",
        divPintado: "pruebaContenedor2",
        divContenedorTabla: "LaTabla2",
        urleliminar: "TipoMedicamento/eliminarTipoMedicamento",
        nombreparametroeliminar: "id",
        paginar: false
    }

    objFormularioTipoMedicamento1 = {
        type: "fieldset",
        legend: "Campos pruebas",
        idformulario: "frmGuardarTipoMedicamento",
        urlguardar: "TipoMedicamento/GuardarDatos",
        urlrecuperar: "TipoMedicamento/recuperarTipomedicamento",
        parametrorecuperar: "iidtipomedicamento",
        pos: "bottom",
        posid: "divBusquedaForm",
        formulario: [
            [
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true

                },
                {
                    class: "col-md-6",
                    label: "Id tipo medicamento",
                    name: "idtipomedicamento",
                    readonly: true


                },
                {
                    class: "col-md-6",
                    label: "Nombre",
                    name: "nombre",
                    classControl: "ob max-100 min-3 sl"
                }
            ],
            [
                {
                    class: "col-md-12",
                    type: "textarea",
                    label: "Descripciòn",
                    name: "descripcion",
                    classControl: "ob max-200 min-5 slcenb"
                }
            ]

        ]
    }
    pintar(objGlobalTipoMedicamento1, objFormularioTipoMedicamento1, bjFormularioMedicamento)

}


function Listar() {
    AgregarTabla({
        url: "Home/ListarUser",
        cabeceras: ["ID", "Nombre"],
        propiedades: ["id", "name"],
        NameElement: "tableId"
    })
}
