function calcularImc() {
    var nome = document.getElementById("textNome");
    var peso = parseFloat(document.getElementById("textPeso").value.replace(",", "."));
    var altura = parseFloat(document.getElementById("textAltura").value.replace(",", "."));
    var imc = peso / (altura * altura);
    alert('Obrigado ' + nome.value + ' seu imc é ' + imc);
}
