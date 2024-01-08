function estaEntre(num, min, max, inclusivo = false) {
    if (inclusivo) {
        return (num >= min && num <= max)
    } else {
        return (num > min && num < max)
    }
}

console.log(estaEntre(10, 50, 100))