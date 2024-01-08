function objetoParaArray(obj) {
    const arr = []
    for (let x in obj) {
        arr.push([x, obj[x]])
    }
    return arr

    // const chaves = Object.keys(objeto)
    // return resultado = chaves.map( chave => [chave, objeto[chave]] )
}

const obj = {
    nome: "Raphael",
    idade: 20,
    peso: 68.5
}

console.log(objetoParaArray(obj))