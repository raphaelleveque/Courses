function receberMelhorEstudante(obj) {
    const melhorEstudante = {nome: '', media: Number.MIN_VALUE}
    for (let nome in obj) {
        let media = obj[nome].reduce((acumulador, somatotal) => acumulador + somatotal) 
                                                                 / obj[nome].length
        if (media > melhorEstudante.media) {
            melhorEstudante.nome = nome
            melhorEstudante.media = media
        }
    }
    return melhorEstudante
}

console.log(receberMelhorEstudante({
    Joao: [8, 7.6, 8.9, 6],
    Mariana: [9, 6.6, 7.9, 8],
    Carla: [7, 7, 8, 9]
}))