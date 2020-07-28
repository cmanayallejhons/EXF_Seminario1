var tabla;

function addRowDT(data) {
    tabla = $("#tbl_Alumnos").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].pE_IDPERSONA,
            data[i].pE_NOMBRE,
            data[i].pE_APELLIDOPAT,
            data[i].pE_APELLIDOMAT,
            data[i].pE_IDENTIFICACION,
            data[i].pE_FECHANAC,
            data[i].pE_TELEFONO,
            data[i].pE_DIRECCION,

            '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>&nbsp;' +
            '<button type="button" value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'
        ]);
    }
}



function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "FrmRegistrarUsuario.aspx/ListarAlumnos",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, " \n" + thrownError);
        },
        success: function (data) {
            //console.log(data.d);
            addRowDT(data.d);
        }
    });
}


function updateDataAjax() {

    var obj = JSON.stringify({ id: JSON.stringify(data[0]),
        nom: $("#txtModalNombre").val(),
        pat: $("#txtModalPat").val(),
        mat: $("#txtModalMat").val(),
        dni: $("#txtModalDNI").val(),
        fecha: $("#txtModalFecha").val(),
        tel: $("#txtModalTelefono").val(),
        direccion: $("#txtModalDireccion").val() })
        

    $.ajax({
        type: "POST",
        url: "FrmRegistrarUsuario.aspx/ActualizarAlumno",
        data: obj,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            console.log(response);
            /*if (response.d) {
                alert("Registro actualizado de manera correcta.");
            } else {
                alert("No se pudo actualizar el registro.");
            }*/
        }
    });

}

function deleteDataAjax(data) {

    var obj = JSON.stringify({ id: JSON.stringify(data) });

    $.ajax({
        type: "POST",
        url: "FrmRegistrarUsuario.aspx/EliminarAlumno",
        data: obj,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d) {
                alert("Registro eliminado de manera correcta.");
            } else {
                alert("No se pudo eliminar el registro.");
            }
        }
    });
}

// evento click para boton actualizar
$(document).on('click', '.btn-edit', function (e) {
    e.preventDefault();

    var row = $(this).parent().parent()[0];
    data = tabla.fnGetData(row);
    fillModalData();

});


// evento click para boton eliminar
$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();
    //primer método: eliminar la fila del datatble
    var row = $(this).parent().parent()[0];
    var data = tabla.fnGetData(row);

    deleteDataAjax(data[0]);
    //segundo método: enviar el codigo del paciente al servidor y eliminarlo, renderizar el datatable
    // paso 1: enviar el id al servidor por medio de ajax
    //deleteDataAjax(dataRow[0]);
    // paso 2: renderizar el datatable
    //sendDataAjax();

});


// cargar datos en el modal
function fillModalData() {

    $("#txtModalNombre").val(data[1]);
    $("#txtModalPat").val(data[2]);
    $("#txtModalMat").val(data[3]);
    $("#txtModalDNI").val(data[4]);
    $("#txtModalFecha").val(data[5]);
    $("#txtModalTelefono").val(data[6]);
    $("#txtModalDireccion").val(data[7]);


}

// enviar la informacion al servidor
$("#btnactualizar").click(function (e) {
    e.preventDefault();
    updateDataAjax();


    //sendDataAjax();
});

// Llamando a la funcion de ajax al cargar el documento
sendDataAjax();