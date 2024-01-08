function calcularSalario(horas, salarioPorHora) {
    let salario = horas * salarioPorHora
    return `Salário igual a R$${salario.toFixed(2)}`
}

console.log(calcularSalario(120, 17))