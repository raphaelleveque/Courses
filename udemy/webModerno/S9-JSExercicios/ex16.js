function somentePares(arr) {
    return arr.filter((elem, i) => elem % 2 == 0 && i % 2 == 0)
}

console.log(somentePares([10, 70, 22, 43]))