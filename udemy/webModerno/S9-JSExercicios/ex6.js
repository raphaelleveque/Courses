function inverso(a){
    if (typeof a == "boolean")
        return !a
    else if (typeof a == "number") 
        return -a
    else
        return "Booleano ou Inteiro esperado, mas o parâmetro é do tipo " + typeof a;
}

console.log(inverso(10))