function removerPropriedade(objeto, propriedade) {
    delete objeto[propriedade]
    return objeto
}

console.log(removerPropriedade({nome: "Raphael", idade: 20, peso: 68}, "peso"))