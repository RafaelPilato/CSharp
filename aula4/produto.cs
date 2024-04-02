// ./produto.cs

public class Produto{
    public string nome{get;set;}
    public string codigo{get;set;}
    public decimal preco{get;set;}

    public string ExibirDetalhes(){
        string detalhes = $"Nome: {nome}\nCodigo: {codigo}\nPreço: {preco}\n";
        return detalhes;
    }

    public string AtualizarPreco(decimal novoPreco){
        this.preco = novoPreco;
        string aviso = "Preço atualizado com sucesso!\n";
        return aviso;
    }
}