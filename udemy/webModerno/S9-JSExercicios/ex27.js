function inverterParametros(obj) {
    const newObj = {}
    for (x in obj) {
        newObj[obj[x]] = x
    }
    return newObj
} 

console.log(inverterParametros({a: 1, b: 2, c: 3}))