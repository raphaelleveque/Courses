function funcaoDaSorte(num) {
    let sorteado = Math.floor(Math.random() * (10) + 1)
    if (num == sorteado) {
        return `Parabéns, o número sorteado foi ${sorteado}`
    } return `Que pena, o número sorteado foi ${sorteado}`
}

console.log(funcaoDaSorte(10))