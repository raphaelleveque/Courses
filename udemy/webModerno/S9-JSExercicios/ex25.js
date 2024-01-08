function palavrasSemelhantes(palavra, arrayDePalavras) {
    return arrayDePalavras.filter(w => w.includes(palavra))
}

console.log(palavrasSemelhantes("pro", ["programacao", "profissao", "java"]))