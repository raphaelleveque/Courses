function repetir(elemento, vezes) {
    const arr = []
    for(let i = 0; i < vezes; i++) {
        arr.push(elemento)
    }
    return arr
    // return Array(quantidade).fill(item)
}

console.log(repetir("codigo", 2))