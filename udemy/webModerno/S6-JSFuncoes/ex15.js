function escolherCarro(carro) {
    switch (carro) {
        case "Hatch":
            console.log("Compra efetuada com sucesso")
            break
        case "Sedan": case "Motocicleta": case "Caminhonete":
            console.log("Tem certeza que não prefere outro modelo?")
            break
        default:
            console.log("Modelo de carro inválido")
    }   
}


console.log(escolherCarro('Hatch'));
console.log(escolherCarro('Motocicleta'));
console.log(escolherCarro('Sedan'));
console.log(escolherCarro('Caminhonete'));
console.log(escolherCarro('Jetski'));