class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
        alert("Incremento");
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
        alert("Decremento");
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]')
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQuantidade = $(linhaDoItem).find('input').val();

        return{
            Id: itemId,
            Quantidade: novaQuantidade
        }
    }

    postQuantidade(data) {
        $.ajax({
            url: 'pedido/updateQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        })
    }
}
var carrinho = new Carrinho();