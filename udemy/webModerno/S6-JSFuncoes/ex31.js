let meuArray = []
for (let i = 0; i < 10; i++) {
    meuArray.push(Math.random() * 22 - 10)
}

let sum = 0
meuArray.forEach(element => {
    if (element < 0)
        sum++
})

console.log(sum)