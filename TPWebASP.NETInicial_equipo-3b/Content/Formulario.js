function validarFormulario() {
    const dni = document.getElementById("dniText").value;
    const mensaje = document.getElementById("lbldni");

    if (dni.trim() === "" || isNaN(dni)) {
        mensaje.textContent = "El DNI debe ser numérico y no estar vacío.";
        return false;
    }

    if (dni.length !== 8) {
        mensaje.textContent = "El DNI debe tener 8 dígitos.";
        return false;
    }

    mensaje.textContent = "";
    return true;
}
