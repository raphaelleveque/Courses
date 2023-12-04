function calculoNota(nota) {
    if (nota > 38 && nota % 5 >= 3) {
        nota = (Math.trunc(nota / 5) + 1) * 5
    }
    return nota
}

console.log(calculoNota(84))