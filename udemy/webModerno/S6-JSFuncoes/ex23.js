function calcularNotaFinal(n1, n2, n3) {
    if (n1 > n2 && n1 > n3) {
        return 0.4 * n1 + 0.3 * n2 + 0.3 * n3
    } else if (n2 > n3) {
        return 0.4 * n2 + 0.3 * n3 + 0.3 * n1
    } else {
        return 0.4 * n3 + 0.3 * n2 + 0.3 * n1
    }
}

console.log("Nota: "+ calcularNotaFinal(2.8, 6, 3.5).toFixed(2))