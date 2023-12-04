class Pedido {
    constructor(codigo, descricao, preco) {
        this.Codigo = codigo
        this.Descricao = descricao
        this.Preco = preco
    }

    valorFinal(quantidade) {
        return this.Preco * quantidade
    }
}

let pedidos = []
pedidos.push(new Pedido(100, "Cachorro quente", 3.00))
pedidos.push(new Pedido(200, "Hamburguer Simples", 4.00))
pedidos.push(new Pedido(300, "Cheeseburguer", 5.50))
pedidos.push(new Pedido(400, "Bauru", 7.50))
pedidos.push(new Pedido(500, "Refrigerante", 3.50))
pedidos.push(new Pedido(600, "Suco", 2.80))

let codigo = 100, quantidade = 8
console.log(pedidos.find(pedido => pedido.Codigo === codigo).valorFinal(quantidade));

codigo = 300, quantidade = 6
console.log(pedidos.find(pedido => pedido.Codigo === codigo).valorFinal(quantidade))
