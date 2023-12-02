function bhaskara(a, b, c) {
    let delta = b**2 - 4 * a * c
    if (delta < 0) return "Delta é negativo"
    return [((-b + Math.pow(delta, 0.5))/ 2 * a), ((-b - Math.pow(delta, 0.5))/ 2 * a)]
}

let x = bhaskara(1, 0, -144)
if (typeof x === "string") console.log(x)
else console.log(x[0], x[1])