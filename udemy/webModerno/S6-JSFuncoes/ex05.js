function truncate(a) {
    return `R$${a.toFixed(2).replace(".", ",")}`
}

console.log(0.1 + 0.2)
console.log(truncate(0.1 + 0.2))