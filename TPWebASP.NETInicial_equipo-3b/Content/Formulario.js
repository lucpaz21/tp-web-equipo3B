
window.onload = function () {
    const dniText = document.getElementById("dniText");
    if (dniText) {
        dniText.addEventListener("keyup", validarNumeros);
    }
}

//function validarNumeros() {
//    const dni = document.getElementById("dniText").value;
//    const cp = document.getElementById("codigoPostal").value;
//    const mensajeDNI = document.getElementById("lbldni");
//    const mensajeCP = document.getElementById("lblCp");


//    if (dni.trim() === "" || !/^\d+$/.test(dni)) {
//        mensajeDNI.textContent = "Este campo debe ser numérico y no estar vacío.";
//        return false;
//    }

//    if (dni.length !== 8) {
//        mensajeDNI.textContent = "El campo debe contener 8 dígitos.";
//        return false;
//    }

//    if (cp.trim() === "" || !/^\d+$/.test(cp)) {
//        mensajeCP.textContent = "Este campo debe ser numérico y no estar vacío.";
//        return false;
//    }

//    return true;
//}

//function validarLetras() {
//    const nombre = document.getElementById("nombre").value;
//    const apellido = document.getElementById("apellido").value;
//    const ciudad = document.getElementById("ciudad").value;
//    const mensajeNombre = document.getElementById("lblNombre");
//    const mensajeApellido = document.getElementById("lblApellido");
//    const mensajeCiudad = document.getElementById("lblCiudad")

//    let esValido = true;

//        if (nombre === "") {
//            esValido = false;
//            mensajeNombre.textContent = "Este campo no puede estar vacío";
//        } else if (!/^[A-Za-z]+$/.test(nombre)) {
//            esValido = false;
//            mensajeNombre.textContent = "El nombre solo puede contener letras";
//        }

//        if (apellido === "") {
//            esValido = false;
//            mensajeApellido.textContent = "Este campo no puede quedar vacío";
//        } else if (!/^[A-Za-z]+$/.test(apellido)) {
//            esValido = false;
//            mensajeApellido.textContent = "El apellido solo puede contener letras";
//        }

//        if (ciudad === "") {
//            esValido = false;
//            mensajeCiudad.textContent = "Este campo no puede quedar vacío";
//        } else if (!/^[A-Za-z]+$/.test(ciudad)) {
//            esValido = false;
//            mensajeCiudad.textContent = "La ciudad solo puede contener letras";
//        }
  
//    return esValido;

//}


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
    const numerosValidos = validarNumeros();
    const letrasValidas = validarLetras();
    validarCamposVacios();

    return numerosValidos && letrasValidas;
}



