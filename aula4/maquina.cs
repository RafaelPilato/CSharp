// ./maquina.cs

public class Maquina{
    public int id{get;set;}
    public string marca{get;set;}
    public string modelo{get;set;}

    public List<Produto> produtos = new List<Produto>();

    public string ExibirInformacoes(){
        string informacoes = $"ID: {this.id}\nMarca: {this.marca}\nModelo: {this.modelo}\n";
        return informacoes;
    }

    public string IniciarProducao(){
        string avisoIniciar = "Produção iniciada!";
        return avisoIniciar;
    }

    public void IncluirProduto(Produto p){
        this.produtos.Add(p);
    }
}