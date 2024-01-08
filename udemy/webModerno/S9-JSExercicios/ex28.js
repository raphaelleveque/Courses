function filtrarPorQuantidadeDeDigitos(array, digitos) {
    return array.map(num => num.toString()).filter(num => num.length == digitos)
}

console.log(filtrarPorQuantidadeDeDigitos([38, 2, 365, 10, 125, 11], 2))