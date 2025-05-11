
window.onload = function () {
    const dniText = document.getElementById("dniText");
    if (dniText) {
        dniText.addEventListener("keyup", validarNumeros);
    }
}

function validarNumeros(idCampo, idMensaje, longitud = 0) {
    const valor = document.getElementById(idCampo).value;
    const mensaje = document.getElementById(idMensaje);

    if (valor.trim() === "" || !/^\d+$/.test(valor)) {
        mensaje.textContent = "Este campo debe ser numérico y no estar vacío.";
        mensaje.style.color = "red";
        return false;
    }

    if (longitud > 0 && valor.length !== longitud) {
        mensaje.textContent = `El campo debe contener ${longitud} dígitos.`;
        mensaje.style.color = "red";
        return false;
    }

    mensaje.textContent = "Campo válido";
    mensaje.style.color = "green";
    return true;
}


function validarLetras(idCampo, idMensaje) {
    const valor = document.getElementById(idCampo).value;
    const mensaje = document.getElementById(idMensaje);

    const regexValor = /^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$/;

    if (valor.trim() === "") {
        mensaje.textContent = "Este campo no puede estar vacío";
        mensaje.style.color = "red";
        return false;
    } else if (!regexValor.test(valor)) {
        mensaje.textContent = "Solo se permiten letras y espacios";
        mensaje.style.color = "red";
        return false;
    }

    mensaje.textContent = "Campo válido";
    mensaje.style.color = "green";
    return true;
}

function validarEmail(idCampo, idMensaje) {
    const valor = document.getElementById(idCampo).value;
    const mensaje = document.getElementById(idMensaje);

    const regexEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (valor.trim() === "") {
        mensaje.textContent = "El correo no puede estar vacío.";
        mensaje.style.color = "red";
        return false;
    } else if (!regexEmail.test(valor)) {
        mensaje.textContent = "Formato de correo no válido.";
        mensaje.style.color = "red";
        return false;
    }

    mensaje.textContent = "Correo válido.";
    mensaje.style.color = "green";
    return true;
}

function validarCamposVacios(idCampo, idMensaje) {
    const valor = document.getElementById(idCampo).value;
    const mensaje = document.getElementById(idMensaje);

    if (valor.trim() === "") {
        mensaje.textContent = "Este campo no debe estar vacío";
        mensaje.style.color = "red";
        return false;
    }

    mensaje.textContent = "Campo válido";
    mensaje.style.color = "green";
    return true;
}


function validarFormulario() {
    const dniValido = validarNumeros('dniText', 'lbldni', 8);
    const nombreValido = validarLetras('nombre', 'lblNombre');
    const apellidoValido = validarLetras('apellido', 'lblApellido');
    const emailValido = validarEmail('email', 'lblEmail');
    const direccionValida = validarCamposVacios('direccion', 'lblDireccion');
    const ciudadValida = validarLetras('ciudad', 'lblCiudad');
    const cpValido = validarNumeros('codigoPostal', 'lblCp');

    if (!dniValido || !nombreValido || !apellidoValido || !emailValido || !direccionValida || !ciudadValida || !cpValido ) {
        return false;
    }

    return true;
}



