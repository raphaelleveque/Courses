function despesasTotais(arr) {
    return arr.map(obj => obj.preco).reduce((acumulador, valorAtual) => acumulador + valorAtual)
}

console.log(despesasTotais([
    {nome: "Jornal online", categoria: "Informação", preco: 89.99},
    {nome: "Cinema", categoria: "Entretenimento", preco: 150}
    ]))