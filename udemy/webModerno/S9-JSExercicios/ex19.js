const somarValores = arr => arr.reduce((acumulador, valorAtual) => acumulador + valorAtual)
const calcularMedia = arr => somarValores(arr) / arr.length

console.log(calcularMedia([1, 2, 3, 4, 5]))