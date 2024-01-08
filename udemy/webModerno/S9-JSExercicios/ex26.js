function excluindoVogais(frase) {
    const vogais = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
    return [...frase].filter(char => !vogais.includes(char)).join('')
}

console.log(excluindoVogais("Cod3r"))