const anoBissexto = ano => {
    if (ano % 400 == 0) return "Bissexto"
    if (ano % 4 == 0 && ano % 100 != 0) return "Bissexto"
    return "Não bissexto"
}

console.log(anoBissexto(2024))