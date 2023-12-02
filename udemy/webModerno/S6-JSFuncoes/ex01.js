function operacoes(a, b) {
    if (typeof a === "number" && typeof b === "number") {
        console.log(`Soma: ${a + b}`)
        console.log(`Subtração: ${a - b}`)
        console.log(`Multiplicação: ${a * b}`)
        console.log(`Divisão: ${a / b}`)
    } else {
        console.log("Not a Number")
    }
}

operacoes(10, 3)
operacoes(10, 'teste')