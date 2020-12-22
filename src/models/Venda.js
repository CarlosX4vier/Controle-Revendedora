class Venda {
    constructor(id, revendedora, produto, bruto, data, lucro, lucroRevendedor) {
        this.id = id
        this.revendedora = revendedora
        this.produto = produto
        this.bruto = bruto
        this.data = data
        this.lucro = lucro
        this.lucroRevendedor = lucroRevendedor
    }
}

module.exports = Venda