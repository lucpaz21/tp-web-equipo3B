
window.onload = function () {
    const dniText = document.getElementById("dniText");
    if (dniText) {
        dniText.addEventListener("keyup", validarNumeros);
    }
}

function validarNumeros() {
    const dni = document.getElementById("dniText").value;
    const cp = document.getElementById("codigoPostal").value;
    const mensajeDNI = document.getElementById("lbldni");
    const mensajeCP = document.getElementById("lblCp");


    if (dni.trim() === "" || !/^\d+$/.test(dni)) {
        mensajeDNI.textContent = "Este campo debe ser numérico y no estar vacío.";
        return false;
    }

    if (dni.length !== 8) {
        mensajeDNI.textContent = "El campo debe contener 8 dígitos.";
        return false;
    }

    if (cp.trim() === "" || !/^\d+$/.test(cp)) {
        mensajeCP.textContent = "Este campo debe ser numérico y no estar vacío.";
        return false;
    }

    mensajeDNI.textContent = "";
    return true;
}

function validarLetras() {
    const nombre = document.getElementById("nombre").value;
    const apellido = document.getElementById("apellido").value;
    const ciudad = document.getElementById("ciudad").value;
    const mensajeNombre = document.getElementById("lblNombre");
    const mensajeApellido = document.getElementById("lblApellido");
    const mensajeCiudad = document.getElementById("lblCiudad")

    let esValido = true;

    if (nombre === "") {
        esValido = false;
        mensajeNombre.textContent = "Este campo no puede estar vacío";
    } else if (!/^[A-Za-z]+$/.test(nombre)) { 
        esValido = false;
        mensajeNombre.textContent = "El nombre solo puede contener letras";
    }

    if (apellido === "") {
        esValido = false;
        mensajeApellido.textContent = "Este campo no puede quedar vacío";
    } else if (!/^[A-Za-z]+$/.test(apellido)) { 
        esValido = false;
        mensajeApellido.textContent = "El apellido solo puede contener letras";
    }

    if (ciudad === "") {
        esValido = false;
        mensajeCiudad.textContent = "Este campo no puede quedar vacío";
    } else if (!/^[A-Za-z]+$/.test(ciudad)) {  
        esValido = false;
        mensajeCiudad.textContent = "La ciudad solo puede contener letras";
    }

    return esValido;

}


function validarCamposVacios() {
    const direccion = document.getElementById("direccion").value;
    const mensajeDireccion = document.getElementById("lblDireccion");

    if (direccion === "") {
        mensajeDireccion.textContent = "Este campo no debe estar vacío";
        return false;
    }
    return true;
}

function validarFormulario() {
    const numerosValidos = validarNumeros();
    const letrasValidas = validarLetras();
    validarCamposVacios();

    return numerosValidos && letrasValidas;
}



