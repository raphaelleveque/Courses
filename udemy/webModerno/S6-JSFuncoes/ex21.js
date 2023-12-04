function calcularPreco(idade) {
    let valor = 100
    if (idade < 10) {
        valor += 80
    } else if (idade >= 10 && idade <= 30) {
        valor += 95
    } else {
        valor += 130
    }
    return valor
}

console.log(calcularPreco(8));
console.log(calcularPreco(15));
console.log(calcularPreco(35));
console.log(calcularPreco(52));
console.log(calcularPreco(80));