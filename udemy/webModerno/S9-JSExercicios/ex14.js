function filtrarNumeros(arr) {
    return arr.filter(elem => typeof elem === "number")
}

console.log(filtrarNumeros(["oi", 3, 'b', 12, "Ola", 2.46]))