function multiplicar(a, b) {
    let soma = a
    for (let i = 1; i < b; i++) {
        soma += a
    }
    return soma
}

console.log(multiplicar(7, 7))