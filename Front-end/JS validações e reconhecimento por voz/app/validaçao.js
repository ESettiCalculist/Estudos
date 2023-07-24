function verificaChutePossuiValor(chute) {
    const numero = +chute

    if (chuteInvalido(numero)) {
        elementoChute.innerHTML +='<div>Valor invalido</div>'
        return
    }

    if(numeroMaiorOuMenor(numero)){
        elementoChute.innerHTML += `
        <div> Valor invalido: o numero secreto precisa estar entre ${menorValor} e ${maiorValor}</div>
        `
        return
    }

    if (numero === numeroSecreto) {
        document.body.innerHTML = `
        <h2>Voce Acertou</h2>
        <h3> O Numero Secreto era ${numeroSecreto}
        `
    } else if (numero > numeroSecreto) {
        elementoChute.innerHTML += `
        <div>O numero secreto é menor <i class="fa-solid fa-down-long"></i></div>
        `
    } else {
        elementoChute.innerHTML += `
        <div>O numero secreto é maior <i class="fa-solid fa-up-long"></i></div>
        `
    }
}

function chuteInvalido(numero) {
    return Number.isNaN(numero)
}

function numeroMaiorOuMenor(numero) {
    return numero > maiorValor || numero < menorValor
}
