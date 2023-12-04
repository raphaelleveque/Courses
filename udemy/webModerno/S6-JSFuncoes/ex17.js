const calculoSalario = (plano, salario) => {
    switch (plano) {
        case 'A':
            return salario * 1.1
        case 'B':
            return salario * 1.15
        case 'C':
            return salario * 1.2
        default:
            return "Plano Inváido"
    }
}

console.log(calculoSalario('A', 1000));
console.log(calculoSalario('B', 1000));
console.log(calculoSalario('C', 1000));
console.log(calculoSalario('D', 1000));
