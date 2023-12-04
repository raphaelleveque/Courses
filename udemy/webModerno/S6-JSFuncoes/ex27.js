function calcularCrescimento(tam1, taxa1, tam2, taxa2) {
    if (tam1 == tam2) {
        return "Tamanhos iguais"
    }
/*
 * TAM1 é maior, mas a taxa de crescimento de TAXA2 é maior
 * Portanto, Tam2 irá passar tam1
 * 
 * Tam1 + taxa1X < Tam2 + Taxa2X
 * (Tam1 - Tam2) < (Taxa2 - Taxa1)X
 * (Tam1 - Tam2) / (Taxa2 - Taxa1) < X
 * 
 */
    if (tam1 > tam2 && taxa1 < taxa2) {
        return `${(tam1 - tam2) / (taxa2 - taxa1)} anos`
    }
    if (tam1 < tam2 && taxa1 > taxa2) {
        return `${(tam2 - tam1) / (taxa1 - taxa2)} anos`
    }

    return "Impossível de ultrapassar de tamanho"
}

console.log(calcularCrescimento(150, 2, 130, 4));
