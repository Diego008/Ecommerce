function mascaraCpf() {
    var tam = document.getElementById("txtCpf").value;
    if (tam.length == 3 || tam.length == 7) {
        document.getElementById("txtCpf").value += ".";
    }

    if (tam.length == 11) {
        document.getElementById("txtCpf").value += "-";
    }

}

function mascaraRg() {
    var tam = document.getElementById("txtRg").value;

    if (tam.length == 2 || tam.length == 6) {
        document.getElementById("txtRg").value += ".";
    }

    if (tam.length == 10) {
        document.getElementById("txtRg").value += "-";
    }
}

function mascaraCep() {
    var tam = document.getElementById("txtCep").value;

    if (tam.length == 5) {
        document.getElementById("txtCep").value += "-";
    }
}

function mascaraContato() {
    var key = event.keyCode;
    var tam = document.getElementById("txtContato").value;

    if (key != 8 && key != 46) {
        if (tam.length == 0) {
            document.getElementById("txtContato").value += "(";
        }

        if (tam.length == 3) {
            document.getElementById("txtContato").value += ")";
        }

        if (tam.length == 8) {
            document.getElementById("txtContato").value += "-";
        }
    }
}