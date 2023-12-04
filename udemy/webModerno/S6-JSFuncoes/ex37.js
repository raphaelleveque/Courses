function pa(n, a1, r) {
    let soma = 0
    for (let i = 0; i < n; i++) {
        soma += a1
        console.log(a1)
        a1 += r
    }
    console.log("soma = " + soma)
}

function pg(n, a1, q) {
    let soma = 0
    for (let i = 0; i < n; i++) {
        soma += a1
        console.log(a1)
        a1 *= q
    }
    console.log("soma = " + soma)
}

pa(10, 10, 15)
console.log('----------------');
pg(10, 5, 3)