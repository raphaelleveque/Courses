function swap(vetorA, vetorB) {
    let size = vetorA.length <= vetorB.length ? vetorA.length : vetorB.length
    
    for (let i = 0; i < size; i++) {
        [vetorA[i], vetorB[i]] = [vetorB[i], vetorA[i]]
    }
    
    console.log('Novo vetor A: ' + vetorA)
    console.log('Novo vetor B: ' + vetorB)
}

let vetorA = [1, 2, 3]
let vetorB = [4, 5, 6]

swap(vetorA, vetorB)