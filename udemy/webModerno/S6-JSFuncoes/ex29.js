function sumRange(vetor) {
    sum = 0
    return vetor.filter(x => x >= 10 && x <= 20).length
}

console.log(sumRange([1, 2, 3, 5, 8, 10, 12, 14, 16, 30]))