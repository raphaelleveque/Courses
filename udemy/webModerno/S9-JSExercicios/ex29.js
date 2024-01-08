function segundoMaior(array) {
    // Maior, segundoMaior
    const maiores = [Number.MIN_VALUE, Number.MIN_VALUE]
    array.forEach(element => {
        if (element > maiores[0]) {
            maiores[1] = maiores[0]
            maiores[0] = element 
        } else if (element > maiores[1]) {
            maiores[1] = element
        }
    });
    return maiores[1]
}

console.log(segundoMaior([1, 2, 5, 7, 8]))