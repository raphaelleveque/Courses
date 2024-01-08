function contarCaracteres(char, frase) {
    let count = 0
    frase.split('').forEach(element => {
        if (element == char) count++
    })
    return count
    // return [...frase].filter(caractere => caractere === caractereBuscado).length
}

console.log(contarCaracteres("r", "A sorte favorece os audazes"))