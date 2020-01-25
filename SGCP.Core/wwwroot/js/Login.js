var serial = localStorage.getItem("serial");


function controle(con) {
    if (con === "False") {
        requisitaChave();
    }
}

function requisitaChave() {

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            var ret = JSON.parse(this.responseText);
            serial = ret.chave;
            document.cookie = ret.passe;
            localStorage.setItem("serial", serial);
        }
        if (this.status === 404) {
            alert("ocorreu uma falha no servidor");
            document.getElementById("butLogar").innerHTML = "Sign in";

        }
    };
    xhttp.open("POST", "/Login/chave", true);
    xhttp.send();

}


function criptografa() {

    var nome = document.getElementById("Nome").value;
    var senha = document.getElementById("Senha").value;
    var valor = nome + " " + senha;
    document.getElementById("butLogar").innerHTML = `<span class="spinner-border mr-2"></span> Loading...`;

    var chaveByte = string2Bin(serial);
    var valorByte = string2Bin(valor);

    var segurancaByte = new Array(valorByte.length);
    var retorno = new Array(valorByte.length);
    for (var o = 0; o < valorByte.length; o++) {
        segurancaByte[o] = valorByte[o] + chaveByte[o];
    }

    enviaLogin(segurancaByte);
}

function enviaLogin(credencial) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            var retorno = this.responseText;
            switch (retorno) {
                case "ok":
                    window.location.href = "/Home/Index";
                    break;
                case "loginErro":
                    document.getElementById("falha").setAttribute("class", "alert-danger mb-4 h-100 p-2 text-center visible");
                    document.getElementById("butLogar").innerHTML = "Sign in";
                    break;
                default:
                    document.body.innerHTML = retorno;
                    break;
            }

        }
    };
    xhttp.open("POST", "/Login/Loga?" + "usu=" + credencial, true);
    xhttp.send();
}

function string2Bin(str) {
    var result = [];
    for (var i = 0; i < str.length; i++) {
        result.push(str.charCodeAt(i));
    }
    return result;
}

function bin2String(array) {
    return String.fromCharCode.apply(String, array);
}