function maiorOuIgual(a, b) {
    if(typeof a != typeof b) return false
    return a >= b
}

console.log(maiorOuIgual(10, "10"))